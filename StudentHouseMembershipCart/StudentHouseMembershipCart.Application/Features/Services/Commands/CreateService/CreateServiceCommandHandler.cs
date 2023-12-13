using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public CreateServiceCommandHandler(IApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<SHMResponse> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var serviceExisted = await _dbContext.Service.Where(x => x.ServiceName == request.ServiceName && !x.IsDelete).FirstOrDefaultAsync();
            if (serviceExisted != null)
            {
                throw new BadRequestException("The services already exists!");
            }
            var category = await _dbContext.Category.Where(x => x.Id == Guid.Parse(request.CategoryId) && !x.IsDelete).FirstOrDefaultAsync();
            if (category == null)
            {
                throw new NotFoundException("The category have not existed!");
            }
            double priceAfterDiscount = request.OriginalPrice - (request.DiscountPercent/100)*request.OriginalPrice;
            var service = new Domain.Entities.Service
            {
                ServiceName = request.ServiceName,
                ServiceDescription = request.ServiceDescription,
                //Giá bán
                Price = priceAfterDiscount,
                //Giá gốc
                OriginalPrice = request.OriginalPrice,
                Unit = request.Unit,
                Image = request.ImageURL,
                CategoryId = Guid.Parse(request.CategoryId),
                Created = DateTime.Now,
                IsDelete = false
            };
            _dbContext.Service.Add(service);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
    }
}