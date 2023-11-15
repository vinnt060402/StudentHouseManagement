using MediatR;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Queries.GetReportWorkByBookingDetailId
{
    public class GetReportWorkByBookingDetailIdQuery : IRequest<List<ReportWorkData>>
    {
        public string BookingDetailId { get; set; } = null!;
    }
}