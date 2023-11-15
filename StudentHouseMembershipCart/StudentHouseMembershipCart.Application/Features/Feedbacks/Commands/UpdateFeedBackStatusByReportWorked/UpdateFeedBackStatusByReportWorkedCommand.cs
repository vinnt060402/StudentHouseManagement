using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackStatusByReportWorked
{
    public class UpdateFeedBackStatusByReportWorkedCommand : IRequest<SHMResponse>
    {
        public Guid AttendReportId { get; set; }
    }
}