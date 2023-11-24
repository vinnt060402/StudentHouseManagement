using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments;
using static StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking.GetAllBookingNewCommandHandler;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByStudentId
{
    public class GetBookingByStudentIdNewCommandHandler : IRequestHandler<GetBookingByStudentIdNewCommand, List<BookingDataNew>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetBookingByStudentIdNewCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<BookingDataNew>> Handle(GetBookingByStudentIdNewCommand request, CancellationToken cancellationToken)
        {
            var bookingList = await (from b in _dbContext.Booking
                                join a in _dbContext.Apartment
                                on b.ApartmentId equals a.Id
                                where 
                                a.StudentId == request.StudentId &&
                                a.IsDelete == false
                                select b)
                                .OrderBy(x => x.Created).ToListAsync();

            var result = new List<BookingDataNew>();

            if (!bookingList.Any())
            {
                return result;
            }
            foreach (var booking in bookingList)
            {
                var apartment = await _dbContext.Apartment
                    .FirstOrDefaultAsync(a => a.Id == booking.ApartmentId && !a.IsDelete);

                if (apartment != null)
                {
                    var studentName = await GetStudentName(apartment.Id);
                    var statusContract = StatusContract(booking.StatusContract);

                    var bookingData = new BookingDataNew
                    {
                        Id = booking.Id,
                        StudentName = studentName,
                        TotalPay = booking.TotalPay,
                        ApartmentId = apartment.Id,
                        ApartmentData = _mapper.Map<ApartmentDto>(apartment),
                        StatusContract = statusContract,
                        Created = booking.Created,
                        //ListServiceOfBookingDetail = await HandleFindServiceOfBookingDetail(booking.Id)
                    };

                    result.Add(bookingData);
                }
            }
            return result;
        }
        #region Private Function
        private async Task<List<ServiceOfBookingDetail>> HandleFindServiceOfBookingDetail(Guid bookingId)
        {
            List<ServiceOfBookingDetail> result = new List<ServiceOfBookingDetail>();
            List<ServiceAndBookingDetailModel> listServiceAndBookingDetailModel = new List<ServiceAndBookingDetailModel>();
            //(1) Check kiểm tra xem booking này có order package không
            var listBookingDetailPackage = await _dbContext.BookingDetailOfPakcage.Where(x => x.BookingId == bookingId).ToListAsync();
            //(2) Check kiểm tra xem booking này có order service không
            var listBookingDetailService = await _dbContext.BookingDetailOfService.Where(x => x.BookingId == bookingId).ToListAsync();

            //Nếu (1) có thì tìm hết những service có trong Package đã tạo
            if (listBookingDetailPackage.Any())
            {
                foreach (var bookingdetail in listBookingDetailPackage)
                {
                    var listServiceId = await _dbContext.PackageService.Where(x => x.PackageId == bookingdetail.PackageId).Select(x => x.ServiceId).ToListAsync();
                    if (listServiceId.Any())
                    {
                        foreach (var item in listServiceId)
                        {
                            var serviceAndBookingDetailModel = new ServiceAndBookingDetailModel()
                            {
                                BookingDetailId = bookingdetail.Id,
                                TypeOfBookingDetail = "1",
                                ServiceId = item
                            };
                            listServiceAndBookingDetailModel.Add(serviceAndBookingDetailModel);
                        }
                    }
                }
            }
            //Nếu (2) có thì tìm hết những service đã book
            if (listBookingDetailService.Any())
            {
                foreach (var bookingDetail in listBookingDetailService)
                {
                    var serviceAndBookingDetailModel = new ServiceAndBookingDetailModel()
                    {
                        BookingDetailId = bookingDetail.Id,
                        TypeOfBookingDetail = "2",
                        ServiceId = bookingDetail.ServiceId
                    };
                    listServiceAndBookingDetailModel.Add(serviceAndBookingDetailModel);
                }
            }
            //Ở những bước trước đã tìm được ServiceAndBookingDetailModel, mỗi phần tử nó có chứa những field đã mô tả
            //Giờ thì mình cần gọp những thằng có ServiceId = nhau nhưng khác BookingDetailId và TypeOfBookingDetail
            foreach (var item in listServiceAndBookingDetailModel)
            {
                var service = await _dbContext.Service.Where(x => x.Id == item.ServiceId).SingleOrDefaultAsync();
                if (!result.Any() || !result.Select(x => x.ServiceId).Contains(item.ServiceId))
                {
                    if (service != null)
                    {
                        List<BookingDetailDataNew> BookingDetailThatServiceIsBelongTo = new List<BookingDetailDataNew>();
                        var serviceOfBookingDetail = new ServiceOfBookingDetail()
                        {
                            ServiceId = service.Id,
                            ServiceName = service.ServiceName,
                            Unit = service.Unit,
                        };
                        if (item.TypeOfBookingDetail == "1")
                        {
                            var bookingDetailPackage = listBookingDetailPackage.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailName = "Booking Package " + service.ServiceName!.Trim() + " From " + bookingDetailPackage.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailPackage.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailPackage.StartDate,
                                EndDate = bookingDetailPackage.EndDate,
                                BookingDetailType = "1",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };
                            BookingDetailThatServiceIsBelongTo.Add(bookingDetailDataNew);
                        }
                        if (item.TypeOfBookingDetail == "2")
                        {
                            var bookingDetailService = listBookingDetailService.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailName = "Bookng Service " + service.ServiceName!.Trim() + " From " + bookingDetailService.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailService.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailService.StartDate,
                                EndDate = bookingDetailService.EndDate,
                                BookingDetailType = "2",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };
                            BookingDetailThatServiceIsBelongTo.Add(bookingDetailDataNew);
                        }
                        serviceOfBookingDetail.BookingDetailThatServiceIsBelongTo = BookingDetailThatServiceIsBelongTo;
                        result.Add(serviceOfBookingDetail);
                    }
                }
                else if (result.Select(x => x.ServiceId).Contains(item.ServiceId))
                {
                    var serviceOfBookingDetail = result.Where(x => x.ServiceId == item.ServiceId).First();
                    if (service != null)
                    {
                        if (item.TypeOfBookingDetail == "1")
                        {
                            var bookingDetailPackage = listBookingDetailPackage.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailName = "Booking Package " + service.ServiceName!.Trim() + " From " + bookingDetailPackage.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailPackage.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailPackage.StartDate,
                                EndDate = bookingDetailPackage.EndDate,
                                BookingDetailType = "1",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };
                            serviceOfBookingDetail!.BookingDetailThatServiceIsBelongTo!.Add(bookingDetailDataNew);
                        }
                        if (item.TypeOfBookingDetail == "2")
                        {
                            var bookingDetailService = listBookingDetailService.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailName = "Bookng Service " + service.ServiceName!.Trim() + " From " + bookingDetailService.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailService.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailService.StartDate,
                                EndDate = bookingDetailService.EndDate,
                                BookingDetailType = "2",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };
                            serviceOfBookingDetail!.BookingDetailThatServiceIsBelongTo!.Add(bookingDetailDataNew);
                        }
                    }
                }
            }
            return await Task.FromResult(result);
        }
        private async Task<string> GetStudentName(Guid apartmentId)
        {
            try
            {
                var studentExist = await _dbContext.Apartment.Where(a => !a.IsDelete && a.Id == apartmentId).Select(a => a.StudentId).SingleOrDefaultAsync();
                var applicationUserExist = await _dbContext.Student.Where(s => !s.IsDelete && s.Id == studentExist).Select(s => s.ApplicationUserId).SingleOrDefaultAsync();
                var studentNameExist = await _dbContext.ApplicationUsers.Where(s => s.Id == applicationUserExist).Select(s => s.FullName).SingleOrDefaultAsync();

                return studentNameExist;
            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }
        }

        private string StatusContract(int? status)
        {
            switch (status)
            {
                case 1:
                    return "Finished";
                case 0:
                    return "On Going";
                default:
                    return "Pending";
            }
        }
        #endregion
    }
}
