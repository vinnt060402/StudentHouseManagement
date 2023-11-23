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

        public UpdateServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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
            service.Image = request.ImageURL;
            service.OriginalPrice = request.OriginalPrice;
            service.Unit = request.Unit;
            service.Price = request.OriginalPrice - (request.DiscountPercent / 100) * request.OriginalPrice;
            service.CategoryId = request.CategoryId != null ? Guid.Parse(request.CategoryId) : service.CategoryId;
            _dbContext.Service.Update(service);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}