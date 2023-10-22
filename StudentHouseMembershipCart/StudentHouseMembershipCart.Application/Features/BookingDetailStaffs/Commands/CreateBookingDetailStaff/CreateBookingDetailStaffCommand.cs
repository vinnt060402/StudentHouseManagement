namespace StudentHouseMembershipCart.Application.Features.BookingDetailStaffs.Commands.CreateBookingDetailStaff
{
    /// <summary>
    /// Assign task booking detail cho staff
    /// </summary>
    public class CreateBookingDetailStaffCommand
    {
        public string BookingDetailId { get; set; } = null!;
        public string StaffId { get; set; } = null!; 
        public string? AssignBy { get; set; } 
    }
}
