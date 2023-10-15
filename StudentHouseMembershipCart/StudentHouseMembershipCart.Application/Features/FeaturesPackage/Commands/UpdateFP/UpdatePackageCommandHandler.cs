﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.PackageServices.Commands.UpdatePackageServiceCommand;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.UpdateFP
{
    public class UpdatePackageCommandHandler : IRequestHandler<UpdatePackageCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public UpdatePackageCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(UpdatePackageCommand request, CancellationToken cancellationToken)
        {
            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(request.PackageId)).SingleOrDefaultAsync();
            if (package == null)
            {
                throw new NotFoundException("The package have not existed!");
            }
            if (package.IsDelete)
            {
                throw new BadRequestException("The package have been deleted!");
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
                package.DayDoServiceInWeek = request.DayDoServiceInWeek;
                package.TotalPrice = totalPrice;
                package.PackageDescription = request.PackageDescription;
                package.WeekNumberBooking = request.weekNumberBooking;
                package.NumberOfPerWeekDoPackage = request.numberOfPerWeekDoPackage;
                package.PackageName = request.PackageName ?? package.PackageName;
                package.LastModified = DateTime.Now;
                package.LastModifiedBy = request.UpdateBy ?? package.LastModifiedBy;
                _dbContext.Package.Update(package);
                var updatePackageServiceRequest = new UpdatePackageServiceCommand()
                {
                    ListServiceId = request.ListServiceId,
                    PackageId = Guid.Parse(request.PackageId),
                    UpdateBy = request.UpdateBy,
                };
                var updatePackageServiceResponse = await _mediator.Send(updatePackageServiceRequest);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}
