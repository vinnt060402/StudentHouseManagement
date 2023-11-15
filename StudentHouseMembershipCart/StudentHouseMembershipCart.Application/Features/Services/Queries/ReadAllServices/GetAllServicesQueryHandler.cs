/*using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

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
            var listServices = await _context.Service.ToListAsync();
            if (!listServices.Any())
            {
                throw new NotFoundException("Have no service!");
            }
            var listResponse = new List<ServiceData>();
            foreach (var service in listServices)
            {
                var response = _mapper.Map<ServiceData>(service);
                listResponse.Add(response);
            }
            return listResponse;
        }
    }
}
*/