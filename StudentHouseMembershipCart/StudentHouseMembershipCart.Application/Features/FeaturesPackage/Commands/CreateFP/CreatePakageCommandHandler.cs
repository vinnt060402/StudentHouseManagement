using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.PackageServices.Commands.CreatePackageServiceCommand;
using StudentHouseMembershipCart.Domain.Entities;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP
{
    public class CreatePakageCommandHandler : IRequestHandler<CreatePakageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public CreatePakageCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreatePakageCommand request, CancellationToken cancellationToken)
        {
            var packageIdResult = string.Empty;
            var packageExisted = await _dbContext.Package.Where(x => x.PackageName == request.PackageName).ToListAsync();
            if (packageExisted.Any())
            {
                throw new BadRequestException("The package have already existed!");
            }
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                double? totalPrice = 0;
                foreach (var service in request.ListServiceId)
                {
                    var servicePrice = _dbContext.Service.Where(x => x.Id == service).Select(x => x.Price).SingleOrDefault();
                    var servicePriceInPackge = servicePrice * request.weekNumberBooking * request.numberOfPerWeekDoPackage;
                    totalPrice += servicePriceInPackge;
                }
                var package = new Package()
                {
                    PackageName = request.PackageName,
                    WeekNumberBooking = request.weekNumberBooking,
                    NumberOfPerWeekDoPackage = request.numberOfPerWeekDoPackage,
                    DayDoServiceInWeek = request.DayDoServiceInWeek,
                    Image = request.ImageUrl,
                    TotalPrice = totalPrice,
                    CreateBy = request.CreateBy,
                    Created = DateTime.Now,
                    IsDelete = false
                };
                _dbContext.Package.Add(package);
                var createPackageServiceRequest = new CreatePackageServiceCommand()
                {
                    PackageId = package.Id,
                    ListServiceId = request.ListServiceId,
                    CreateBy = package.CreateBy,
                };
                var createPackageServiceResponse = await _mediator.Send(createPackageServiceRequest);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
                packageIdResult = package.Id.ToString();
            }

            return new SHMResponse
            {
                Message = packageIdResult
            };
        }
    }
}
