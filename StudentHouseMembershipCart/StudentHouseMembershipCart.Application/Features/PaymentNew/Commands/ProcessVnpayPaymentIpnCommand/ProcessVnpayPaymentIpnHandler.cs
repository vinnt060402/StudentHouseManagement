using AutoMapper;
using MediatR;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.VnPay.Config;
using StudentHouseMembershipCart.VnPay.Response;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.ProcessVnpayPaymentIpnCommand
{
    public class ProcessVnpayPaymentIpnHandler :
        IRequestHandler<ProcessVnpayPaymentIpn, VnpayPayIpnResponse>
    {
        private IApplicationDbContext _dbContext;
        private readonly ICurrentUserService currentUserService;
        private readonly VnpayConfig vnpayConfig;
        private IMapper _mapper;
        public ProcessVnpayPaymentIpnHandler(IApplicationDbContext dbContext,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IOptions<VnpayConfig> vnpayConfigOptions)
        {
            this._dbContext = dbContext;
            this.currentUserService = currentUserService;
            this._mapper = mapper;
            this.vnpayConfig = vnpayConfigOptions.Value;
        }

        public async Task<VnpayPayIpnResponse> Handle(
            ProcessVnpayPaymentIpn request, CancellationToken cancellationToken)
        {
            var result = new VnpayPayIpnResponse();
            var resultData = new VnpayPayIpnResponse();

            try
            {
                var isValidSignature = request.IsValidSignature(vnpayConfig.HashSecret);

                if (isValidSignature)
                {
                    var p = _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.vnp_TxnRef).SingleOrDefault();
                    var payment = _mapper.Map<PaymentDto>(p);

                    if (payment != null)
                    {
                        if (payment.RequiredAmount == (request.vnp_Amount / 100))
                        {
                            if (payment.PaymentStatus != "1")
                            {
                                string message = "";
                                string status = "";

                                if (request.vnp_ResponseCode == "00" &&
                                   request.vnp_TransactionStatus == "00")
                                {
                                    status = "0";
                                    message = "Tran success";
                                }
                                else
                                {
                                    status = "-1";
                                    message = "Tran error";
                                }
                                var pt = new PaymentTransaction()
                                {
                                    PaymentTransactionId = DateTime.Now.Ticks.ToString(),
                                    TranMessage = message,
                                    TranPayload = JsonConvert.SerializeObject(request),
                                    TranStatus = status,
                                    TranAmount = request.vnp_Amount,
                                    TranDate = DateTime.Now.ToString(),
                                };
                                /// Update database
                                _dbContext.PaymentTransaction.Add(pt);
                                await _dbContext.SaveChangesAsync();
                                /// Confirm success
                                resultData.Set("00", "Confirm success");
                            }
                            else
                            {
                                resultData.Set("02", "Order already confirmed");
                            }
                        }
                        else
                        {
                            resultData.Set("04", "Invalid amount");
                        }
                    }
                    else
                    {
                        resultData.Set("01", "Order not found");
                    }
                }
                else
                {
                    resultData.Set("97", "Invalid signature");
                }
            }
            catch (Exception ex)
            {
                /// TODO: process when exception
                resultData.Set("99", "Input required data");
            }

            result = resultData;
            return result;
        }
    }
}
