/*using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetailNew
{
    public class UpdateBookingDetailNewCommandHandler : IRequestHandler<UpdateBookingDetailNewCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public UpdateBookingDetailNewCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(UpdateBookingDetailNewCommand request, CancellationToken cancellationToken)
        {
            var bookingDetail = await _dbContext.BookingDetail.AsNoTracking().Where(x => x.Id == request.BookingDetailId).SingleOrDefaultAsync();
            if (bookingDetail == null)
            {
                throw new NotFoundException("Can not find this booking detail!");
            }
            bookingDetail.IsRe_Newed = true;
            bookingDetail.RenewStartDate = request.RenewStartDate;
            _dbContext.BookingDetail.Update(bookingDetail);
            await _dbContext.SaveChangesAsync();
            Task.WaitAll();
            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}*/