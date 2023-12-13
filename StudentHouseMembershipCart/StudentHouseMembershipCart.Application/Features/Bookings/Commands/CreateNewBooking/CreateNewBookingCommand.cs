using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateNewBookingCommand : IRequest<SHMResponse>
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
        public string PaymentNew { get; set; } = null!;
        public List<PackageCreateDate>? ListPackage { get; set; }
        public List<ServiceCreateDate>? ListService { get; set; }

    }
    public class ServiceCreateDate
    {
        public string ServiceId { get; set; } = null!;
        public int QuantityOfServiceOrdered { get; set; }
    }
}
