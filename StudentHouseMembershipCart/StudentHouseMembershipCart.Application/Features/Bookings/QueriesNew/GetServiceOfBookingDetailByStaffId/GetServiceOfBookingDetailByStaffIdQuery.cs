using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStaffId
{
    public class GetServiceOfBookingDetailByStaffIdQuery : IRequest<List<ServiceOfBookingDetailOfStaff>>
    {
        public Guid StaffId { get; set; }
    }
}
