using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UpdateServiceCommandHandler(IApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, IMapper mapper
            )
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<SHMResponse> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _dbContext.Service.Where(x => x.Id == Guid.Parse(request.ServiceId)).SingleOrDefaultAsync();
            if (service == null)
            {
                throw new NotFoundException("The service have not existed!");
            }
            if (service.IsDelete)
            {
                throw new BadRequestException("The service have been deleted!");
            }
            var category = await _dbContext.Category.Where(x => x.Id == Guid.Parse(request.CategoryId) && !x.IsDelete).FirstOrDefaultAsync();
            if (category == null)
            {
                throw new NotFoundException("The category have not existed!");
            }
            service.ServiceName = request.ServiceName ?? service.ServiceName;
            service.ServiceDescription = request.ServiceDescription ?? service.ServiceDescription;
            /*service.Quantity = request.Quantity ?? service.Quantity;*/
            service.Image = request.ImageURL ?? service.Image;
            service.CategoryId = request.CategoryId != null ? Guid.Parse(request.CategoryId) : service.CategoryId;
            service.LastModified = DateTime.Now;
            service.LastModifiedBy = request.UpdateBy ?? service.LastModifiedBy;
            _dbContext.Service.Update(service);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}