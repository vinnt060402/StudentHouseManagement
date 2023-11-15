using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetFeedBackByFBID
{
    public class GetFeedBackByFBIDQueryHandler : IRequestHandler<GetFeedBackByFBIDQuery, FeedBackData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetFeedBackByFBIDQueryHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<FeedBackData> Handle(GetFeedBackByFBIDQuery request, CancellationToken cancellationToken)
        {
            var feedback = await _dbContext.FeedBack.Where(x => x.Id == Guid.Parse(request.FeedBackId)).SingleOrDefaultAsync();
            if (feedback == null)
            {
                throw new NotFoundException("Can not find this feedback!");
            }
            var data = _mapper.Map<FeedBackData>(feedback);
            if (DateTime.Compare(feedback.Created, feedback.LastModified ?? DateTime.Now) < 0)
            {
                data.DateFeedBack = feedback.LastModified.ToString();
            }
            else
            {
                data.DateFeedBack = null;
            }
            return data;
        }
    }
}

