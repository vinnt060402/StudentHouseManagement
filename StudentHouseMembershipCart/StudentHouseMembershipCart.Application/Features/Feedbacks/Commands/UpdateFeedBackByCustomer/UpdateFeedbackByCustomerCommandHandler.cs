using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.UpdateFeedBackByCustomer
{
    public class UpdateFeedbackByCustomerCommandHandler : IRequestHandler<UpdateFeedbackByCustomerCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdateFeedbackByCustomerCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdateFeedbackByCustomerCommand request, CancellationToken cancellationToken)
        {
            var feedBack = await _dbContext.FeedBack.Where(x => x.Id == request.FeedBackId).SingleOrDefaultAsync();
            if (feedBack == null)
            {
                throw new BadRequestException("Can not find this feedback!");
            }
            if(feedBack != null && feedBack.FeedBackStatus == 2)
            {
                throw new BadRequestException("This feedback has done!");
            }
            feedBack.FeedBackName = request.FeedBackName;
            feedBack.FeedBackDescription = request.FeedBackDescription;
            feedBack.FeedBackImage = request.FeedBackImageUrl;
            feedBack.FeedBackRating = request.FeedBackRating;
            feedBack.FeedBackStatus = 2;
            _dbContext.FeedBack.Update(feedBack);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}