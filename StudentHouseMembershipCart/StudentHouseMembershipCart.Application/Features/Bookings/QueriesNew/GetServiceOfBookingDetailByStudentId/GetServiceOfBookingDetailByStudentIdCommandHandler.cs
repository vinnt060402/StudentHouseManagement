using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using static StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking.GetAllBookingNewCommandHandler;

namespace StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStudentId
{
    public class GetServiceOfBookingDetailByStudentIdCommandHandler : IRequestHandler<GetServiceOfBookingDetailByStudentIdCommand, List<ServiceOfBookingDetail>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetServiceOfBookingDetailByStudentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ServiceOfBookingDetail>> Handle(GetServiceOfBookingDetailByStudentIdCommand request, CancellationToken cancellationToken)
        {
            List<ServiceOfBookingDetail> result = new List<ServiceOfBookingDetail>();
            List<ServiceAndBookingDetailModel> listServiceAndBookingDetailModel = new List<ServiceAndBookingDetailModel>();
            //(1) Check kiểm tra xem student này có order package không
            var listBookingDetailPackage = await(from bdOfPackage in _dbContext.BookingDetailOfPakcage
                                                 
                                                 join booking in _dbContext.Booking 
                                                 on bdOfPackage.BookingId equals booking.Id

                                                 join a in _dbContext.Apartment
                                                 on booking.ApartmentId equals a.Id

                                                 where 
                                                 a.StudentId == request.StudentId &&
                                                 bdOfPackage.BookingDetailStatus != 1
                                                 select bdOfPackage
                                                 ).ToListAsync();
            //(2) Check kiểm tra xem student này có order service không
            var listBookingDetailService = await (from bdOfService in _dbContext.BookingDetailOfService

                                                  join booking in _dbContext.Booking
                                                  on bdOfService.BookingId equals booking.Id

                                                  join a in _dbContext.Apartment
                                                  on booking.ApartmentId equals a.Id

                                                  where 
                                                  a.StudentId == request.StudentId &&
                                                  bdOfService.BookingDetailStatus != 1
                                                  select bdOfService
                                     ).ToListAsync();
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
                                BookingDetailId = bookingDetailPackage.Id,
                                BookingDetailName = "Booking Package " + service.ServiceName!.Trim() + " From " + bookingDetailPackage.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailPackage.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailPackage.StartDate,
                                EndDate = bookingDetailPackage.EndDate,
                                BookingDetailType = "1",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };/*
                            if (bookingDetailDataNew.RemainingTaskDuration == 0)
                            {
                                continue;
                            }*/
                            BookingDetailThatServiceIsBelongTo.Add(bookingDetailDataNew);
                        }
                        if (item.TypeOfBookingDetail == "2")
                        {
                            var bookingDetailService = listBookingDetailService.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailId = bookingDetailService.Id,
                                BookingDetailName = "Bookng Service " + service.ServiceName!.Trim() + " From " + bookingDetailService.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailService.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailService.StartDate,
                                EndDate = bookingDetailService.EndDate,
                                BookingDetailType = "2",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };/*
                            if (bookingDetailDataNew.RemainingTaskDuration == 0)
                            {
                                continue;
                            }*/
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
                                BookingDetailId = bookingDetailPackage.Id,
                                BookingDetailName = "Booking Package " + service.ServiceName!.Trim() + " From " + bookingDetailPackage.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailPackage.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailPackage.StartDate,
                                EndDate = bookingDetailPackage.EndDate,
                                BookingDetailType = "1",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };/*
                            if(bookingDetailDataNew.RemainingTaskDuration == 0)
                            {
                                continue;
                            }*/
                            serviceOfBookingDetail!.BookingDetailThatServiceIsBelongTo!.Add(bookingDetailDataNew);
                        }
                        if (item.TypeOfBookingDetail == "2")
                        {
                            var bookingDetailService = listBookingDetailService.Where(x => x.Id == item.BookingDetailId).Single();
                            var bookingDetailDataNew = new BookingDetailDataNew()
                            {
                                BookingDetailId = bookingDetailService.Id,
                                BookingDetailName = "Bookng Service " + service.ServiceName!.Trim() + " From " + bookingDetailService.StartDate!.Value.ToString("yyyy/MM/dd").Trim() + " To " + bookingDetailService.EndDate!.Value.ToString("yyyy/MM/dd").Trim(),
                                StartDate = bookingDetailService.StartDate,
                                EndDate = bookingDetailService.EndDate,
                                BookingDetailType = "2",
                                RemainingTaskDuration = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == item.BookingDetailId && x.ServiceId == service.Id).Select(x => x.RemainingTaskDuration).FirstAsync()
                            };/*
                            if (bookingDetailDataNew.RemainingTaskDuration == 0)
                            {
                                continue;
                            }*/
                            serviceOfBookingDetail!.BookingDetailThatServiceIsBelongTo!.Add(bookingDetailDataNew);
                        }
                    }
                }
            }

            return await Task.FromResult(result);
        }
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
    }
}
