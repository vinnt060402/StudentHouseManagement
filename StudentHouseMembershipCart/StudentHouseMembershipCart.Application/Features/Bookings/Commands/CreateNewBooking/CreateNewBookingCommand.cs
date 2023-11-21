using MediatR;
using Org.BouncyCastle.Math.EC.Rfc7748;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateNewBookingCommand : IRequest<SHMResponse>
    {
        public string ApartmentId { get; set; } = null!;
        /// <summary>
        /// UserName
        /// </summary>
        public string CreateBy { get; set; } = null!;
        public string PaymentMethodId { get; set; } = null!;
        public List<PackageCreateDate>? ListPackage { get; set; }
        public List<ServiceCreateDate>? ListService { get; set; }

    }
    public class ServiceCreateDate
    {
        public string ServiceId { get; set; } = null!;
        public int QuantityOfServiceOrdered { get; set; }
    }
}
