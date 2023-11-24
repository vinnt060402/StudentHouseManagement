using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStudentId
{
    public class GetServiceOfBookingDetailByStudentIdCommand : IRequest<List<ServiceOfBookingDetail>>
    {
        public Guid StudentId { get; set; }
    }
}
