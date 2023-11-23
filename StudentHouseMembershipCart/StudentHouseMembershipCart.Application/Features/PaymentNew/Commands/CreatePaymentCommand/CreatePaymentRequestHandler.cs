using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.VnPay.Config;
using StudentHouseMembershipCart.VnPay.Request;
using StudentHouseMembershipCart.Ultils.Helpers;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand
{
    public class CreatePaymentRequestHandler : IRequestHandler<CreatePaymentRequest, PaymentLinkDto>
    {
        private IApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly VnpayConfig vnpayConfig;
        private readonly ICurrentUserService currentUserService;

        public CreatePaymentRequestHandler(
            IConfiguration configuration,
            IApplicationDbContext dbContext, 
            IOptions<VnpayConfig> vnpayConfigOptions, 
            ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            this.vnpayConfig = vnpayConfigOptions.Value;
            this.currentUserService = currentUserService;
            _configuration = configuration;
        }

        public async Task<PaymentLinkDto> Handle(CreatePaymentRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var paymentnew = new Domain.Entities.PaymentNew()
                {
                    PaymentNewId = DateTime.Now.Ticks.ToString(),
                    PaymentContent = request.PaymentContent,
                    PaymentCurrency = request.PaymentCurrency ?? string.Empty,
                    PaymentRefId = Guid.NewGuid().ToString(),
                    RequiredAmount = request.RequiredAmount ?? 0,
                    PaymentDate = DateTime.Now,
                    PaymentStatus = "0",
                    ExpireDate = DateTime.Now.AddMinutes(15),
                    PaymentDestinationId = request.PaymentDestinationId ?? string.Empty,
                };
                _dbContext.PaymentNew.Add(paymentnew);
                await _dbContext.SaveChangesAsync();
                var paymentUrl = string.Empty;
                switch (request.PaymentDestinationId)
                {
                    case "VNPAY":
                        var vnpayRequest = new VnpayPayRequest(
                            _configuration["Vnpay:Version"],
                            _configuration["Vnpay:TmnCode"],
                            DateTime.Now,
                            currentUserService.IpAddress ?? string.Empty,
                            request.RequiredAmount ?? 0,
                            request.PaymentCurrency ?? string.Empty,
                            "other",
                            request.PaymentContent ?? string.Empty,
                            _configuration["Vnpay:ReturnUrl"] ?? string.Empty,
                            paymentnew.PaymentNewId.ToString() ?? string.Empty);
                        paymentUrl = vnpayRequest.GetLink(_configuration["Vnpay:PaymentUrl"], _configuration["Vnpay:HashSecret"]);
                        break;
                    default: break;
                }
                return new PaymentLinkDto
                {
                    PaymentId = paymentnew.PaymentNewId,
                    PaymentUrl = paymentUrl,
                };
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
