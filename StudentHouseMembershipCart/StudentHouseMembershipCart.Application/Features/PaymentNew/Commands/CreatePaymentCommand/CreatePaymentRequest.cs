using MediatR;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand
{
    public class CreatePaymentRequest : IRequest<PaymentLinkDto>
    {
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        public string PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        public string? PaymentDestinationId { get; set; } = string.Empty;

        //public CreateNewBookingCommand CreateNewBookingCommand { get; set; } = null!;
    }
}
