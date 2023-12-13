using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.DeleteService
{
    public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext { get; set; }

        public DeleteServiceCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
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
            service.IsDelete = true;
            _dbContext.Service.Update(service);
            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.DeleteSuccessfully
            };
        }
    }
}