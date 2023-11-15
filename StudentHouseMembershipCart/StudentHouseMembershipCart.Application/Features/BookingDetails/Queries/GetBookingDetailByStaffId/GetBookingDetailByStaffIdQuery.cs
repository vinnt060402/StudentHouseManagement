using MediatR;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailByStaffId
{
    public class GetBookingDetailByStaffIdQuery : IRequest<List<BookingDetailByStaffIdModel>>
    {
        public string StaffId { get; set; } = null!;
    }
}