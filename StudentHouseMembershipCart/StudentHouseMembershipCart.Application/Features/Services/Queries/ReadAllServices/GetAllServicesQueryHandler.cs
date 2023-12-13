using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using static System.Net.Mime.MediaTypeNames;

namespace StudentHouseMembershipCart.Application.Features.Services.Queries.ReadAllServices
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, List<ServiceData>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public GetAllServicesQueryHandler(IApplicationDbContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<ServiceData>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            var listServices = await _context.Service.Where(x => !x.IsDelete).ToListAsync();
            var listResponse = new List<ServiceData>();
            foreach (var service in listServices)
            {
                var discountService = (double)(100 - (service.Price / service.OriginalPrice) * 100);
                var response = new ServiceData
                {
                    Id = service.Id,
                    ServiceName = service.ServiceName,
                    ServiceDescription = service.ServiceDescription,
                    Price = service.Price,
                    Image = service.Image,
                    OriginalPrice = service.OriginalPrice,
                    Unit = service.Unit,
                    DiscountPercent = discountService,
                    CategoryId = service.CategoryId,
                    Created = service.Created,
                    CreateBy = service.CreateBy,
                    LastModified = service.LastModified,
                    LastModifiedBy = service.LastModifiedBy,
                    IsDelete = service.IsDelete,
                };
                
                listResponse.Add(response);
            }
            return listResponse;
        }
    }
}