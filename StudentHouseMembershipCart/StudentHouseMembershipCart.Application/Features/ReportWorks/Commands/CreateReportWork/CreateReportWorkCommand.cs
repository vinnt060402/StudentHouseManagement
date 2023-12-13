using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.CreateReportWork
{
    public class CreateReportWorkCommand : IRequest<SHMResponse>
    {
        public string StaffId { get; set; } = null!;
        public string BookingDetailId { get; set; } = null!;
        public string BookingDetailType { get; set; } = null!;
        public string BookingDetailTille { get; set; } = null!;

    }
}