using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.VnPay.Config;

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
            try {
                var resultData = new PaymentReturnDto();
                var isValidSignature = request.IsValidSignature(vnpayConfig.HashSecret);

                if (isValidSignature) {
                    var payment = await _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.vnp_TxnRef).SingleOrDefaultAsync();
                    if (payment == null) {
                        message = "Not found this payment!!!!!";
                        status = "99";
                        returnUrl = vnpayConfig.HomeUrl;
                        //throw new NotFoundException("Not found this payment!!!!!");
                    }
                    if (payment.PaymentStatus == "1") {
                        message = "Order already confirmed!!!!!";
                        status = "99";
                        returnUrl = vnpayConfig.HomeUrl;
                        //throw new NotFoundException("Order already confirmed!!!!!");
                    }
                    /*                    if((int?)payment.RequiredAmount == (request.vnp_Amount / 100))
                                        {
                                            throw new NotFoundException("Invalid amount!!!!!");
                                        }*/
                    if (request.vnp_ResponseCode == "00") {
                        if (request.vnp_TransactionStatus == "00") {
                            status = "1";
                            message = "Tran success";
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
                        else {
                            status = "-0";
                            message = "Tran error";
                            payment.PaymentStatus = "-1";
                            payment.Signature = request.vnp_SecureHash;
                            payment.PaymentRefId = request.vnp_TxnRef;
                            _dbContext.PaymentNew.Update(payment);

                            //Find Booking
                            var booking = await _dbContext.Booking.Where(x => x.PaymentNewId == payment.PaymentNewId).FirstOrDefaultAsync();
                            if (booking != null) {
                                booking.IsDelete = true;
                                var bookingDetailPackage = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == booking.Id).ToListAsync();
                                foreach (var item in bookingDetailPackage) {
                                    item.IsDelete = true;
                                    _dbContext.BookingDetailOfPakcage.Update(item);
                                }
                                var bookingDetailService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == booking.Id).ToListAsync();
                                foreach (var item in bookingDetailService) {
                                    item.IsDelete = true;
                                    _dbContext.BookingDetailOfService.Update(item);
                                }
                                _dbContext.Booking.Update(booking);
                            }

                            resultData.PaymentStatus = "-1";
                            resultData.PaymentId = payment.PaymentNewId;
                            ///TODO: Make signature
                            resultData.Signature = Guid.NewGuid().ToString();
                            returnUrl = vnpayConfig.HomeUrl;
                        }
                    }
                    else {
                        resultData.PaymentStatus = "10";
                        resultData.PaymentMessage = "Payment process failed";
                        //Find Booking
                        var booking = await _dbContext.Booking.Where(x => x.PaymentNewId == payment.PaymentNewId).FirstOrDefaultAsync();
                        if (booking != null)
                        {
                            booking.IsDelete = true;
                            var bookingDetailPackage = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == booking.Id).ToListAsync();
                            foreach (var item in bookingDetailPackage)
                            {
                                item.IsDelete = true;
                                _dbContext.BookingDetailOfPakcage.Update(item);
                            }
                            var bookingDetailService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == booking.Id).ToListAsync();
                            foreach (var item in bookingDetailService)
                            {
                                item.IsDelete = true;
                                _dbContext.BookingDetailOfService.Update(item);
                            }
                            _dbContext.Booking.Update(booking);
                        }
                        returnUrl = vnpayConfig.HomeUrl;
                    }
                    result = (resultData, returnUrl);
                }
                else {
                    message = "Invalid signature in response!!!!!!!";
                    status = "99";
                    resultData.PaymentStatus = status;
                    resultData.PaymentMessage = message;
                    returnUrl = vnpayConfig.HomeUrl;
                    //Find Booking
                    var payment = await _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.vnp_TxnRef).SingleOrDefaultAsync();
                    if( payment != null )
                    {
                        var booking = await _dbContext.Booking.Where(x => x.PaymentNewId == payment.PaymentNewId).FirstOrDefaultAsync();
                        if (booking != null)
                        {
                            booking.IsDelete = true;
                            var bookingDetailPackage = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == booking.Id).ToListAsync();
                            foreach (var item in bookingDetailPackage)
                            {
                                item.IsDelete = true;
                                _dbContext.BookingDetailOfPakcage.Update(item);
                            }
                            var bookingDetailService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == booking.Id).ToListAsync();
                            foreach (var item in bookingDetailService)
                            {
                                item.IsDelete = true;
                                _dbContext.BookingDetailOfService.Update(item);
                            }
                            _dbContext.Booking.Update(booking);
                        }
                    }
                    result = (resultData, returnUrl);
                }
            }
            catch (Exception ex) {
                message = "Somethings are wrong!!";
                status = "99";
                var resultData = new PaymentReturnDto();
                resultData.PaymentStatus = status;
                resultData.PaymentMessage = message;
                returnUrl = vnpayConfig.HomeUrl;
                //Find Booking
                var payment = await _dbContext.PaymentNew.Where(x => x.PaymentNewId == request.vnp_TxnRef).SingleOrDefaultAsync();
                if (payment != null)
                {
                    var booking = await _dbContext.Booking.Where(x => x.PaymentNewId == payment.PaymentNewId).FirstOrDefaultAsync();
                    if (booking != null)
                    {
                        booking.IsDelete = true;
                        var bookingDetailPackage = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == booking.Id).ToListAsync();
                        foreach (var item in bookingDetailPackage)
                        {
                            item.IsDelete = true;
                            _dbContext.BookingDetailOfPakcage.Update(item);
                        }
                        var bookingDetailService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == booking.Id).ToListAsync();
                        foreach (var item in bookingDetailService)
                        {
                            item.IsDelete = true;
                            _dbContext.BookingDetailOfService.Update(item);
                        }
                        _dbContext.Booking.Update(booking);
                    }
                }
                result = (resultData, returnUrl);
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
            try
            {
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}