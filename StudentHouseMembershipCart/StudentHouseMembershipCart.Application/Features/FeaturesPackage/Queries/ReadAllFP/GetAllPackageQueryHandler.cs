﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.GetTotalPriceOfPackage;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadAllFP
{
    public class GetAllPackageQueryHandler : IRequestHandler<GetAllPackageQuery, List<PackageData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public GetAllPackageQueryHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<List<PackageData>> Handle(GetAllPackageQuery request, CancellationToken cancellationToken)
        {
            var listPackage = await _dbContext.Package.ToListAsync();
            if (!listPackage.Any())
            {
                throw new NotFoundException("Have no package!");
            }
            var listResult = new List<PackageData>();
            foreach(var item in listPackage)
            {
                var getTotalPrice = new GetTotalPriceOfPackageQuery
                {
                    PackageId = item.Id.ToString(),
                    NumberOfPerWeekDoPackage = item.NumberOfPerWeekDoPackage,
                    WeekNumberBooking = item.WeekNumberBooking
                };
                var getTotalPriceResponse = await _mediator.Send(getTotalPrice);
                var result = _mapper.Map<PackageData>(item);
                result.DayDoInWeek = ReturnDayInWeekByDayDoServiceInWeek(item.DayDoServiceInWeek);
                result.TotalPrice = getTotalPriceResponse;
                listResult.Add(result);
            }
            return listResult;
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
