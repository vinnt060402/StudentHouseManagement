using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP;
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
                double totalOriginalPrice = await HandleOriginalPriceOfPackage(request);

                package.PackageName = request.PackageName ?? package.PackageName;
                package.PackageDescription = request.PackageDescription;
                package.Image = request.ImageUrl;
                package.TotalPrice = totalOriginalPrice - (totalOriginalPrice * (request.DiscountPercent / 100));
                package.DiscountPercent = request.DiscountPercent;
                package.TotalOriginalPrice = totalOriginalPrice;
                _dbContext.Package.Update(package);
                var updatePackageServiceRequest = new UpdatePackageServiceCommand()
                {
                    ListServiceId = request.ListServiceId,
                    Quantity = request.Quantity,
                    PackageId = Guid.Parse(request.PackageId),
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
        /// <summary>
        /// Tính toán số tiền gốc của Package : TotalOriginalPrice
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<double> HandleOriginalPriceOfPackage(UpdatePackageCommand request)
        {
            double price = 0;

            foreach (var item in request.ListServiceId)
            {
                var service = await _dbContext.Service.Where(x => x.Id == item).SingleAsync();
                price += (service.Price * request.Quantity) ?? 0;
            }

            return price;
        }
    }
}