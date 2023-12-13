/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport;
using StudentHouseMembershipCart.Domain.Entities;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.CreateBookingDetail
{
    public class CreateBookingDetailCommandHandler : IRequestHandler<CreateBookingDetailCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public CreateBookingDetailCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateBookingDetailCommand request, CancellationToken cancellationToken)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var package = request.PackageDataRequest;

                if (package.IsDelete)
                {
                    throw new NotFoundException("Some package does not existed or was deleted before!!");
                }
                // Calc total day of work 
                var remainingtaskDuration = package.NumberOfPerWeekDoPackage * package.WeekNumberBooking * request.QuantityOfPackageOrdered;
                // Calc price of booking detail
                var price = request.QuantityOfPackageOrdered * package.TotalPrice;
                var bookdingDetail = new BookingDetail
                {
                    TotalPriceOfQuantity = price ?? 0,
                    RemainingTaskDuration = remainingtaskDuration ?? 0,
                    IsRe_Newed = false,
                    RenewStartDate = null,
                    BookingDetailStatus = null,
                    BookingId = request.BookingId,
                    PackageId = request.PackageId,
                    CreateBy = request.CreateBy
                };
                _dbContext.BookingDetail.Add(bookdingDetail);
                await _dbContext.SaveChangesAsync();


                //TODO Create attendence report !!!
                var createAttenceReportRequest = new CreateAttendenceReportCommand
                {
                    StudentId = request.StudentId,
                    BookingDetailId = bookdingDetail.Id.ToString(),
                    StartDay = request.StartDate,
                    TotalDayNeedWork = bookdingDetail.RemainingTaskDuration,
                    TotalDayWorkingInWeek = package.NumberOfPerWeekDoPackage,
                    DayDoBookingDetailInWeek = package.DayDoServiceInWeek,
                };
                var createAttenceReportResponse = await _mediator.Send(createAttenceReportRequest);
                scope.Complete();
                return new SHMResponse
                {
                    Message = bookdingDetail.Id.ToString()
                };
            }

        }
    }
}*/