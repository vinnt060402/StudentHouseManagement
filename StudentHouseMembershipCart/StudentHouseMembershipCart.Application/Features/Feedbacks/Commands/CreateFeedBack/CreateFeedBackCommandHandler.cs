using MediatR;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.CreateFeedBack
{
    public class CreateFeedBackCommandHandler : IRequestHandler<CreateFeedBackCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreateFeedBackCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreateFeedBackCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var feedback = new FeedBack()
                {
                    StudentId = request.StudentId,
                    AttendReportId = request.AttendReportId,
                    FeedBackStatus = 0,
                    CreateBy = request.CreateBy
                };
                _dbContext.FeedBack.Add(feedback);
                await _dbContext.SaveChangesAsync();
                return new SHMResponse()
                {
                    Message = Extensions.CreateSuccessfully
                };
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}