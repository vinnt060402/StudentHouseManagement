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
                double totalOriginalPrice = await HandleOriginalPriceOfPackage(request);

                var package = new Package()
                {
                    PackageName = request.PackageName,
                    PackageDescription = request.PackageDescription,
                    Image = request.ImageUrl,
                    TotalPrice = totalOriginalPrice - (totalOriginalPrice * (request.DiscountPercent/100)),
                    DiscountPercent = request.DiscountPercent,
                    TotalOriginalPrice = totalOriginalPrice,
                    Created = DateTime.Now,
                    IsDelete = false
                };
                _dbContext.Package.Add(package);
                var createPackageServiceRequest = new CreatePackageServiceCommand()
                {
                    PackageId = package.Id,
                    ListSerivceId = request.ListServiceId,
                    Quantity = request.Quantity
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
        /// <summary>
        /// Tính toán số tiền gốc của Package : TotalOriginalPrice
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private async Task<double> HandleOriginalPriceOfPackage(CreatePakageCommand request)
        {
            double price = 0;

            foreach(var item in request.ListServiceId)
            {
                var service = await _dbContext.Service.Where(x => x.Id == item).SingleAsync();
                price += (service.Price * request.Quantity) ?? 0;
            }

            return price;
        }
    }
}