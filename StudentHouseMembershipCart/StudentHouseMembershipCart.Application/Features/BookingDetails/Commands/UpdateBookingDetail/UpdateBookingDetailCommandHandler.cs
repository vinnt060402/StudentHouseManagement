/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetail
{
    public class UpdateBookingDetailCommandHandler : IRequestHandler<UpdateBookingDetailCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public UpdateBookingDetailCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        /// <summary>
        /// Đang giải quyết cho trường hợp Update bởi việc đăng ký.
        /// Bởi vì theo như trong logic thì User khi đã đăng ký xong thì không 
        /// Được Update trực tiếp vào trong đây
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<SHMResponse> Handle(UpdateBookingDetailCommand request, CancellationToken cancellationToken)
        {
            var bookingDetail = await _dbContext.BookingDetail.Where(x => x.Id == request.BookingId && x.PackageId == request.PackageId).SingleOrDefaultAsync();
            if (bookingDetail == null)
            {
                throw new NotFoundException("Does not existed this booking!!");
            }
            var package = await _dbContext.Package.Where(x => x.Id == request.PackageId).SingleOrDefaultAsync();

            if (package == null || package.IsDelete)
            {
                throw new NotFoundException("Some package does not existed or was deleted before!!");
            }
            *//*
             * Trường hợp khi mà IsRe_New not null và bằng true 
             * thì có nghĩa sẽ được gia hạn
             * Và gia hạn đồng nghĩa với việc re new start date not null
             *//*
            if (request.IsRe_Newed != null && request.IsRe_Newed == true && request.RenewStartDate != null && bookingDetail.PackageId == request.PackageId)
            {
                *//*
                 * Cập nhật các field như lastmodified và last modifiedby
                 * Cập nhật thêm vào trong Attendence Report
                 *//*
                bookingDetail.IsRe_Newed = request.IsRe_Newed ?? true;
                bookingDetail.RenewStartDate = request.RenewStartDate;
                bookingDetail.LastModifiedBy = request.UpdateBy;
                // Cập nhật lại tổng giá tiền
                var price = request.QuantityOfPackageOrdered * package.TotalPrice;
                bookingDetail.TotalPriceOfQuantity += price ?? 0;
                // Cập nhật lại số lượng đã đăng ký với package id này của booking detail này
                bookingDetail.QuantityOfPackageOrdered += request.QuantityOfPackageOrdered ?? 0;
                // Cập nhật lại số lượng ngày làm việc cho Remaining Task Duration 
                var remainingtaskDuration = package.NumberOfPerWeekDoPackage * package.WeekNumberBooking * request.QuantityOfPackageOrdered;
                bookingDetail.RemainingTaskDuration += remainingtaskDuration ?? 0;

                _dbContext.BookingDetail.Update(bookingDetail);
                // TODO update attendence report
            }
            await _dbContext.SaveChangesAsync();

            return new SHMResponse
            {
                Message = Extensions.UpdateSuccessfully
            };
        }
    }
}*/