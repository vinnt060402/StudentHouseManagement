/*using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.GetTotalPriceOfPackage
{
    public class GetTotalPriceOfPackageQueryHandler : IRequestHandler<GetTotalPriceOfPackageQuery, double>
    {
        private IApplicationDbContext _dbContext;

        public GetTotalPriceOfPackageQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// Get Total Price of Package
        /// Total Price = (Service Price * WeekNumberBooking * NumberOfPerWeekDoPackage) ++
        /// Bussiness Rule
        /// If Service = 2, discout 5%,
        /// > 2, + 5 for each service (Max 20%)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<double> Handle(GetTotalPriceOfPackageQuery request, CancellationToken cancellationToken)
        {
            int flag = 0;
            double price = 0;
            var packageService = await _dbContext.PackageService.Where(x => x.PackageId == Guid.Parse(request.PackageId)).ToListAsync();
            if (!packageService.Any())
            {
                return 0;
            }
            foreach (var service in packageService)
            {
                var getService = await _dbContext.Service.Where(x => x.Id == service.ServiceId).SingleOrDefaultAsync();
                if (getService != null)
                {
                    flag++;
                    price += (getService.Price * request.WeekNumberBooking * request.NumberOfPerWeekDoPackage)  ?? 0;
                }
            }
            if(flag == 2)
            {
                price = price * 0.95;
            }
            else if(flag > 2)
            {
                var discout = (5 * (flag - 1) > 20) ? 20 : (5 * (flag - 1));
                price = price * (100 - discout);
            }
            return price;
        }
    }
}
*/