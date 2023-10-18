using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.GetTotalPriceOfPackage;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById
{
    public class GetPakageByIdCommandHandler : IRequestHandler<GetPackageByIdCommand, PackageData>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetPakageByIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<PackageData> Handle(GetPackageByIdCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(request.PakageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("Have no package!");
            }
            var result = _mapper.Map<PackageData>(package);
            var getTotalPrice = new GetTotalPriceOfPackageQuery
            {
                PackageId = package.Id.ToString()
            };
            var getTotalPriceResponse = await _mediator.Send(getTotalPrice);
            result.DayDoInWeek = ReturnDayInWeekByDayDoServiceInWeek(package.DayDoServiceInWeek);
            result.TotalPrice = getTotalPriceResponse;
            return result;
        }
        private List<string> ReturnDayInWeekByDayDoServiceInWeek(string day)
        {
            int lengthDay = day.Length;
            var result = new List<string>();
            for (int i = 0; i < lengthDay; i++)
            {
                char c = day.ElementAt(i);
                switch (c)
                {
                    case '1':
                        result.Add("Chủ Nhật");
                        break;
                    case '2':
                        result.Add("Thứ 2");
                        break;
                    case '3':
                        result.Add("Thứ 3");
                        break;
                    case '4':
                        result.Add("Thứ 4");
                        break;
                    case '5':
                        result.Add("Thứ 5");
                        break;
                    case '6':
                        result.Add("Thứ 6");
                        break;
                    case '7':
                        result.Add("Thứ 7");
                        break;
                }
            }
            return result;
        }
    }
}
