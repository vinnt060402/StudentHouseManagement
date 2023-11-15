using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.CreateFeedBack
{
    public class CreateFeedBackCommand : IRequest<SHMResponse>
    {
        public Guid StudentId { get; set; }
        public Guid AttendReportId { get; set; }
        public string? CreateBy { get; set; }
    }
}