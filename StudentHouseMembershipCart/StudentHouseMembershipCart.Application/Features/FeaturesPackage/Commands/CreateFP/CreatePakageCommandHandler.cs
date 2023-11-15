using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
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
                double? totalPrice = await HandlePriceOfPackage(request);

                var package = new Package()
                {
                    PackageName = request.PackageName,
                    WeekNumberBooking = request.WeekNumberBooking,
                    NumberOfPerWeekDoPackage = request.NumberOfPerWeekDoPackage,
                    DayDoServiceInWeek = request.DayDoServiceInWeek,
                    PackageDescription = request.PackageDescription,
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

        private async Task<double> HandlePriceOfPackage(CreatePakageCommand request)
        {
            int flag = 0;
            double price = 0;
            foreach (var serviceId in request.ListServiceId)
            {
                var getService = await _dbContext.Service.Where(x => x.Id == serviceId).SingleOrDefaultAsync();
                if (getService != null)
                {
                    flag++;
                    price += (getService.Price * request.WeekNumberBooking * request.NumberOfPerWeekDoPackage) ?? 0;
                }
            }
            if (flag == 2)
            {
                price = price * 0.95;
            }
            else if (flag > 2)
            {
                var discout = (5 * (flag - 1) > 20) ? 20 : (5 * (flag - 1));
                price = price * (100 - discout);
            }
            return price;
        }
    }
}