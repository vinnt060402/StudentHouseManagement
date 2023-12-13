using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.BookingDetailStaffs.Commands.CreateBookingDetailStaff
{
    /// <summary>
    /// Assign task booking detail cho staff
    /// </summary>
    public class CreateBookingDetailStaffCommand : IRequest<SHMResponse>
    {
        public Guid BookingDetailId { get; set; } 
        public Guid StaffId { get; set; }
        /// <summary>
        /// Cái này dùng để check existed!
        /// </summary>
        public string BookingDetailType { get; set; } = null!;
        /// <summary>
        /// Cái này dùng để check existed!
        /// </summary>
        public string BookingDetailTittle { get; set; } = null!;
    }
}