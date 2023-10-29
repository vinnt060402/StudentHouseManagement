using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.CreateBookingDetail
{
    public class CreateBookingDetailCommand : IRequest<SHMResponse>
    {
        //public string? RemainingTaskDuration { get; set; }
        public Guid StudentId { get; set; }
        public Guid BookingId { get; set; }
        public DateTime StartDate { get; set; } 
        public int? QuantityOfPackageOrdered { get; set; }
        public Guid PackageId { get; set; }
        public string? CreateBy { get; set; }
    }
}
