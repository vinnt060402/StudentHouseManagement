namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBookingDoNotAssignBefore
{
    public class BookingDetailDoNotAssignBeforeData
    {
        public string BookingDetailTittle { get; set; } = null!;
        public string StartDateDoService { get; set; }
        public string EndDateDoService { get; set; }
        public string TimeDoService { get; set; } = null!;
        public Guid ServiceId { get; set; }
        public Guid BookingDetailId { get; set; }   
        public string? BookingDetailType { get; set; }
        public string? Note { get;set; }
    }
}
