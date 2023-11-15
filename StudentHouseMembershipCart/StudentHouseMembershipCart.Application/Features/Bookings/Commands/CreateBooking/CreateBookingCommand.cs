using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<SHMResponse>
    {
        public DateTime StartDate { get; set; }
        public string ApartmentId { get; set; } = null!;
        /// <summary>
        /// UserName
        /// </summary>
        public string CreateBy { get; set; } = null!;
        public string PaymentMethodId { get; set; } = null!;
        public List<PackageCreateDate> ListPackage { get; set; } = null!;
    }
    public class PackageCreateDate
    {
        public string PackageId { get; set; } = null!;
        public int QuantityOfPackageOrdered { get; set; }
    }
}