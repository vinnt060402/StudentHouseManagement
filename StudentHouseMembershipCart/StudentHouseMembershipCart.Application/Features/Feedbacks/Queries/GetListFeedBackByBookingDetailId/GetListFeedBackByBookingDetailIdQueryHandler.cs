using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Queries.GetListFeedBackByBookingDetailId
{
    public class GetListFeedBackByBookingDetailIdQueryHandler : IRequestHandler<GetListFeedBackByBookingDetailIdQuery, List<FeedBackData>>
    {
        private IMapper _mapper;
        private IApplicationDbContext _dbContext;

        public GetListFeedBackByBookingDetailIdQueryHandler(IMapper mapper, IApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<FeedBackData>> Handle(GetListFeedBackByBookingDetailIdQuery request, CancellationToken cancellationToken)
        {
            var listFeedback = await (from fb in _dbContext.FeedBack
                                      join ar in _dbContext.AttendReport
                                      on fb.AttendReportId equals ar.Id

                                      where ar.BookingDetailId == Guid.Parse(request.BookingDetailId)
                                      select fb).ToListAsync();
            if(!listFeedback.Any())
            {
                throw new NotFoundException("Can not find this feedback!");
            }
            List<FeedBackData> listData = new List<FeedBackData>();    
            foreach(var fb in listFeedback)
            {
                var data = _mapper.Map<FeedBackData>(fb);
                if (DateTime.Compare(fb.Created, fb.LastModified ?? DateTime.Now) < 0)
                {
                    data.DateFeedBack = fb.LastModified.ToString();
                }
                else
                {
                    data.DateFeedBack = null;
                }
                listData.Add(data);
            }
            return listData;
        }
    }
}

