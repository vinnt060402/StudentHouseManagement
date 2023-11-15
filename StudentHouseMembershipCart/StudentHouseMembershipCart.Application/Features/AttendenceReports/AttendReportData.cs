namespace StudentHouseMembershipCart.Application.Features.AttendenceReports
{
    public class AttendReportData
    {
        public Guid Id { get; set; }
        public DateTime DateDoPackage { get; set; }
        public Guid BookingDetailId { get; set; }
        public Guid ReportWorkId { get; set; }
        public int AttendenceStatus { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
        public string? FeedbackAvailable { get; set; }
    }
}