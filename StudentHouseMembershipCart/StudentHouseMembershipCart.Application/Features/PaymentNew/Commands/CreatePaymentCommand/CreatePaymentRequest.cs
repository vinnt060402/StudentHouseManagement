using MediatR;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;

namespace StudentHouseMembershipCart.Application.Features.PaymentNew.Commands.CreatePaymentCommand
{
    public class CreatePaymentRequest : IRequest<PaymentLinkDto>
    {
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        public string? PaymentDestinationId { get; set; } = string.Empty;

        public NewBooking NewBooking { get; set; } = null!;
    }
    public class NewBooking
    {
        /// <summary>
        /// Ngay bat dau dich vu
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Ngay ket thuc dich vu
        /// </summary>
        public DateTime? EndDate { get; set; }
        public string ApartmentId { get; set; } = null!;
        public double TotalPrice { get; set; }
        public List<PackageCreateDate>? ListPackage { get; set; }
        public List<ServiceCreateDate>? ListService { get; set; }
    }
}
