using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetailNew;
using StudentHouseMembershipCart.Domain.Entities;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateNewBookingCommandHandler : IRequestHandler<CreateNewBookingCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public CreateNewBookingCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateNewBookingCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // list package
                var listPakageData = new List<Package>();
                if (request.ListPackage != null && request.ListPackage.Any())
                {
                    foreach (var item in request.ListPackage.Select(x => x.PackageId).ToList())
                    {
                        var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(item)).SingleOrDefaultAsync();
                        if (package != null)
                        {
                            listPakageData.Add(package);
                        }
                    }
                }
                // list service
                var listServiceData = new List<Service>();
                if (request.ListService != null && request.ListService.Any())
                {
                    foreach (var item in request.ListService.Select(x => x.ServiceId).ToList())
                    {
                        var service = await _dbContext.Service.Where(x => x.Id == Guid.Parse(item)).SingleOrDefaultAsync();
                        if (service != null)
                        {
                            listServiceData.Add(service);
                        }
                    }
                }
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var booking = new Booking
                    {
                        Contract = CreateContractByApartmentId(request.ApartmentId),
                        TotalPay = request.TotalPrice,
                        StartDate = DateTime.Now,
                        PaymentNewId = request.PaymentNew,
                        ApartmentId = Guid.Parse(request.ApartmentId),
                        StatusContract = 0,
                    };
                    _dbContext.Booking.Add(booking);

                    if (listPakageData.Any())
                    {
                        foreach (var package in listPakageData)
                        {
                            //Thêm Data vào trong bảng BookingDetailOfPackage
                            var packRequest = request.ListPackage!.Where(x => Guid.Parse(x.PackageId) == package.Id).SingleOrDefault();
                            var priceOfPackage = package.TotalPrice * packRequest!.QuantityOfPackageOrdered;
                            var bookingDetailOfPackage = new BookingDetailOfPakcage()
                            {
                                StartDate = request.StartDate,
                                EndDate = request.EndDate,
                                BookingDetailStatus = 0,
                                BookingId = booking.Id,
                                PackageId = package.Id,
                            };
                            _dbContext.BookingDetailOfPakcage.Add(bookingDetailOfPackage);
                            //Thêm Data vào bảng ServiceRemain, bởi vì Bản chất Package vẫn là tập hợp các Service
                            //Nên ta sẽ lưu số lần thực hiện Booking vào trong serviceRemain
                            //Do Package có nhiều Service nên chúng ta sẽ có nhiều lần Add
                            var listServiceInPackage = await _dbContext.PackageService.Where(x => x.PackageId == package.Id).ToListAsync();
                            foreach (var item in listServiceInPackage)
                            {
                                var serviceRemainingTaskDuration = new ServiceRemainingTaskDuration()
                                {
                                    ServiceId = item.ServiceId,
                                    BookingDetailId = bookingDetailOfPackage.Id,
                                    AttendReportForType = "1",
                                    //Số ngày thực hiện bằng số lần Package được Order * Service Quantity được Add vào trong PackageService
                                    RemainingTaskDuration = (packRequest.QuantityOfPackageOrdered * item.QuantityOfService) ?? 0,
                                };
                                _dbContext.ServiceRemainingTaskDuration.Add(serviceRemainingTaskDuration);
                            }
                        }
                    }

                    if (listServiceData.Any())
                    {
                        //Tương tự như ở trên
                        foreach (var service in listServiceData)
                        {
                            var serviceRequest = request.ListService!.Where(x => Guid.Parse(x.ServiceId) == service.Id).SingleOrDefault();
                            var bookingDetailService = new BookingDetailOfService()
                            {
                                StartDate = request.StartDate,
                                EndDate = request.EndDate,
                                BookingDetailStatus = 0,
                                BookingId = booking.Id,
                                ServiceId = service.Id,
                            };
                            _dbContext.BookingDetailOfService.Add(bookingDetailService);
                            var serviceRemainingTaskDuration = new ServiceRemainingTaskDuration()
                            {
                                ServiceId = service.Id,
                                BookingDetailId = bookingDetailService.Id,
                                AttendReportForType = "2",
                                RemainingTaskDuration = serviceRequest!.QuantityOfServiceOrdered
                            };
                            _dbContext.ServiceRemainingTaskDuration.Add(serviceRemainingTaskDuration);
                        }
                    }

                    await _dbContext.SaveChangesAsync();
                    scope.Complete();
                }

            }
            catch (Exception ex)
            {
                throw new BadRequestException(ex.Message);
            }

            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
        #region Private Function
        private string CreateContractByApartmentId(string ApartmentId)
        {
            var user = (from st in _dbContext.Student
                        join apart in _dbContext.Apartment
                        on st.Id equals apart.StudentId
                        where apart.Id == Guid.Parse(ApartmentId)
                        select st.ApplicationUser.FullName).FirstOrDefault();
            return "Hợp đồng " + (user != null ? user.Trim() : "") + " " + DateTime.Now.ToString("yyyy/MM/dd");
        }
        #endregion
    }
}


/*
{
    var apartment = await _dbContext.Apartment.Where(x => x.Id == Guid.Parse(request.ApartmentId)).SingleOrDefaultAsync();
    var studentId = apartment.StudentId.ToString();
    //Đầu tiên kiểm tra xem ở căn hộ đó đã booking cái service hay cái package nào hay chưa,
    //Nếu có thì check ngày của cái package hay service đó đã hết hạn chưa(check bằng cách xem sẽ có ngày bắt đầu và 	
    //ngày kết thúc của cái gói hay dịch vụ riêng, khi mà student bắt đầu kích hoạt gói dịch vụ đó, và cái ngày đó 	 	
    //từ cái bảng bookingDetail, khi tạo thành công booking thì tất cả thời gian của các package or service phải là 	
    //null, thì student kích hoạt nó sẽ tạo ra thời gian mới nhất cho chính nó) -> chưa hết thì nâng cấp cộng dồn, 	 	
    //hết rồi thì gia hạn lại

    //Nếu mà qua cái thời gian của cái booking thì coi như cái service hay cái package đó hết hạn, dựa vào cột 	  	
    //isRenew: isRenew = false là đang hết hạn, nếu đang sử dụng hoặc còn hạn sử dụng thì là true, hết hạn thì auto 	
    //chuyển qua false

    //Thì trong trường hợp này chỉ cần 1 record để check là gói dịch vụ hay package đó đang tạm ngưng hay đang hoạt 	
    //động để kích hoạt lại thôi

    //Tạo sẵn 1 booking entity ở đây
    var listPackageId = request.ListPackage.Select(x => x.PackageId).ToList();
    double totalPrice = 0;
    foreach (var package in listPackageId)
    {
        var getPackageIdRequest = listPakageData.Where(x => x.Id == Guid.Parse(package)).FirstOrDefault();

        var priceOfPackage = getPackageIdRequest.TotalPrice * request.ListPackage.Where(x => x.PackageId == package).Select(x => x.QuantityOfPackageOrdered).FirstOrDefault();
        totalPrice += priceOfPackage ?? 0;
    }
    var booking = new Booking
    {
        Contract = CreateContractByApartmentId(request.ApartmentId),
        TotalPay = totalPrice,
        StartDate = DateTime.Now,
        ApartmentId = Guid.Parse(request.ApartmentId),
        StatusContract = 0,
        CreateBy = request.CreateBy
    };
    _dbContext.Booking.Add(booking);
    Task.WaitAll();

    //Get List Service đã tồn tại và đang được status on going
    //Kiểm tra xem list package nào trong request đang bị trùng
    //Trùng thì Update Booking Detail
    var listContractAtApartmentId = await (from bd in _dbContext.BookingDetail.AsNoTracking()
                                               //Inner join booking
                                           join b in _dbContext.Booking.AsNoTracking()
                                           on bd.BookingId
                                           equals b.Id
                                           //Inner join apartment
                                           join ap in _dbContext.Apartment.AsNoTracking()
                                           on b.ApartmentId
                                           equals ap.Id
                                           //Inner join Package 
                                           join pack in _dbContext.Package.AsNoTracking()
                                           on bd.PackageId
                                           equals pack.Id
                                           //Inner join Service
                                           join service in _dbContext.Service.AsNoTracking()
                                           on bd.ServiceId
                                           equals service.Id

                                           where ap.Id == Guid.Parse(request.ApartmentId) &&
                                                 bd.BookingDetailStatus == 0
                                           select new ContractAtApartment
                                           {
                                               ApartmentId = ap.Id,
                                               BookingdetailId = bd.Id,
                                               PackageId = pack.Id,
                                               PackageName = pack.PackageName,
                                               StartDate = b.StartDate,
                                               IsRe_Newed = bd.IsRe_Newed,
                                               BookingDetailStatus = bd.BookingDetailStatus ?? 0
                                           }
                                           ).ToListAsync();
    if (listContractAtApartmentId.Any())
    {
        foreach (var item in listContractAtApartmentId)
        {
            // Kiểm tra xem có PackageId của Request có cái nào trùng với Pcakge của căn hộ đó đang
            // Trong trạng thái on going hay không
            // Và kiểm tra trạng thái is renew, bởi vì đối với từng lần đăng ký trùng, thì hệ thống sẽ
            // Cập nhật lại hệ isrenew cho booking detail, nên chỉ kiếm những Booking detail nào có is renew bằng False
            // Nếu có thì cập nhật cái trạng thái 
            if (request.ListPackage.Select(x => x.PackageId).ToList().Contains(item.PackageId.ToString().ToUpper()) &&
                                                                               item.BookingDetailStatus == 0 &&
                                                                               !item.IsRe_Newed)
            {
                var updateBookingDetail = new UpdateBookingDetailNewCommand
                {
                    BookingDetailId = item.BookingdetailId,

                };
                var updateBookingDetailResponse = await _mediator.Send(updateBookingDetail);
            }
        }
    }

    await _dbContext.SaveChangesAsync();
    scope.Complete();
}*/