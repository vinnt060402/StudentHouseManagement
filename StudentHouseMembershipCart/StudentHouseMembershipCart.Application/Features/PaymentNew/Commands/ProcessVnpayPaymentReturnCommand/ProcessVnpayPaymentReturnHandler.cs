using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Service.VnPay.Config;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentReturnCommand
{
    public class ProcessVnpayPaymentReturnHandler
        : IRequestHandler<ProcessVnpayPaymentReturn, (PaymentReturnDto, string)>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private readonly VnpayConfig vnpayConfig;

        public ProcessVnpayPaymentReturnHandler(IApplicationDbContext dbContext,
            IMapper mapper,
            IOptions<VnpayConfig> vnpayConfigOptions)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this.vnpayConfig = vnpayConfigOptions.Value;
        }
        public async Task<(PaymentReturnDto, string)> Handle(
            ProcessVnpayPaymentReturn request, CancellationToken cancellationToken)
        {
            string returnUrl = string.Empty;
            string message = "";
            string status = "";
            var result = (new PaymentReturnDto(), "");
            try
            {
                var resultData = new PaymentReturnDto();
                var isValidSignature = request.IsValidSignature(vnpayConfig.HashSecret);

                if (isValidSignature)
                {
                    var payment = await _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.vnp_TxnRef).SingleOrDefaultAsync();
                    if (payment == null)
                    {
                        throw new NotFoundException("Not found this payment!!!!!");
                    }
                    if(payment.PaymentStatus == "1")
                    {
                        throw new NotFoundException("Order already confirmed!!!!!");
                    }
/*                    if((int?)payment.RequiredAmount == (request.vnp_Amount / 100))
                    {
                        throw new NotFoundException("Invalid amount!!!!!");
                    }*/
                    if (request.vnp_ResponseCode == "00")
                    {
                        if (request.vnp_TransactionStatus == "00")
                        {
                            status = "1";
                            message = "Tran success";
                        }
                        else
                        {
                            status = "-0";
                            message = "Tran error";
                        }
                        payment.PaymentStatus = "1";
                        payment.Signature = request.vnp_SecureHash;
                        payment.PaymentRefId = request.vnp_TxnRef;
                        _dbContext.PaymentNew.Update(payment);

                        resultData.PaymentStatus = "00"; 
                        resultData.PaymentId = payment.PaymentNewId;
                        ///TODO: Make signature
                        resultData.Signature = Guid.NewGuid().ToString();
                        returnUrl = vnpayConfig.HomeUrl;
                    }
                    else
                    {
                        resultData.PaymentStatus = "10";
                        resultData.PaymentMessage = "Payment process failed";
                    }
                    result = (resultData, returnUrl);
                }
                else
                {
                    throw new NotFoundException("Invalid signature in response!!!!!");

                }
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Somethings are wrong!!");
            };
            var paymentTransaction = new PaymentTransaction()
            {
                PaymentTransactionId = DateTime.Now.Ticks.ToString(),
                TranMessage = message,
                TranPayload = returnUrl,
                TranStatus = status,
                TranAmount = request.vnp_Amount,
                TranDate = request.vnp_PayDate,
                PaymentNewId = request.vnp_TxnRef,
                TranRefId = request.vnp_TransactionNo
            };
            _dbContext.PaymentTransaction.Add(paymentTransaction);
            await _dbContext.SaveChangesAsync();
            return result;
        }
    }
}
