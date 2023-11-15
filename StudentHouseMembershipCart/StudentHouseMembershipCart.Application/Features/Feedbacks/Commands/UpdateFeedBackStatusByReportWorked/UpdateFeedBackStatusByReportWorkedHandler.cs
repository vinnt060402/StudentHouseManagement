using MediatR;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackStatusByReportWorked
{
    public class UpdateFeedBackStatusByReportWorkedHandler : IRequestHandler<UpdateFeedBackStatusByReportWorkedCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public UpdateFeedBackStatusByReportWorkedHandler(IApplicationDbContext context, IMediator mediator)
        {
            _dbContext = context;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(UpdateFeedBackStatusByReportWorkedCommand request, CancellationToken cancellationToken)
        {
            var reportWork = _dbContext.FeedBack.Where(x => x.AttendReportId == request.AttendReportId).SingleOrDefault();
            if (reportWork == null)
            {
                throw new BadRequestException("Can not found this feedback!");
            }
            reportWork.FeedBackStatus = 1;

            _dbContext.FeedBack.Update(reportWork);
            await _dbContext.SaveChangesAsync();

            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}