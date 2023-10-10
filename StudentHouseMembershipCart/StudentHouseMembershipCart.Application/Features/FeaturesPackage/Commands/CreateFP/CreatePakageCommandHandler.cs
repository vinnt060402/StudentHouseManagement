using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP
{
    public class CreatePakageCommandHandler : IRequestHandler<CreatePakageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreatePakageCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreatePakageCommand request, CancellationToken cancellationToken)
        {
            var packageExisted = await _dbContext.Package.Where(x => x.PackageName == request.PackageName).ToListAsync();
            if (packageExisted.Any())
            {
                throw new BadRequestException("The package have already existed!");
            }
            var package = new Package()
            {
                PackageName = request.PackageName,
                weekNumberBooking = request.weekNumberBooking,
                numberOfPerWeekDoPackage = request.numberOfPerWeekDoPackage,
                Image = request.ImageUrl,
                AdminId = request.AdminId,
                CreateBy = request.CreateBy,
                Created = DateTime.Now,
                IsDelete = false
            };
            _dbContext.Package.Add(package);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = package.Id.ToString(),
            };
        }
    }
}
