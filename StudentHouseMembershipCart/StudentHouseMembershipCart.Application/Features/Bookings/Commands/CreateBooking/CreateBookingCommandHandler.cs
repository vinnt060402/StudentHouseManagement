using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.CreateBookingDetail;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetailNew;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById;
using StudentHouseMembershipCart.Domain.Entities;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IMediator _mediator;

        public CreateBookingCommandHandler(IApplicationDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                //Đầu tiên kiểm tra xem ở căn hộ đó đã có họp đồng nào hay chưa
                //Kiểm tra xem trong họp đồng đó nó đã có những package id nào
                //Nếu trùng với bất kì package nào trong hợp đồng đã có thì
                //Tiến hành thêm ngày vào trong hợp đồng đó
                var listContractAtApartmentId = await (from bd in _dbContext.BookingDetail
                                                       //Inner join booking
                                                       join b in _dbContext.Booking
                                                       on bd.BookingId
                                                       equals b.Id
                                                       //Inner join apartment
                                                       join ap in _dbContext.Apartment
                                                       on b.ApartmentId
                                                       equals ap.Id
                                                       //Inner join Package 
                                                       join pack in _dbContext.Package
                                                       on bd.PackageId
                                                       equals pack.Id

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
                //Tạo sẵn 1 booking entity ở đây
                var listPackageId = request.ListPackage.Select(x => x.PackageId).ToList();
                double totalPrice = 0;
                foreach (var package in listPackageId)
                {
                    var getPackageIdRequest = new GetPackageByIdCommand
                    {
                        PakageId = package
                    };
                    var getPackageIdResponse = await _mediator.Send(getPackageIdRequest);
                    var priceOfPackage = getPackageIdResponse.TotalPrice * request.ListPackage.Where(x => x.PackageId == package).Select(x => x.QuantityOfPackageOrdered).Single();
                    totalPrice += priceOfPackage;
                }
                //TODO FIX CONTRACT
                var booking = new Booking
                {
                    Contract = CreateContractByApartmentId(request.ApartmentId),
                    TotalPay = totalPrice,
                    StartDate = request.StartDate,
                    ApartmentId = Guid.Parse(request.ApartmentId),
                    StatusContract = 0,
                    CreateBy = request.CreateBy
                };
                _dbContext.Booking.Add(booking);
                await _dbContext.SaveChangesAsync();
                //Get List Service đã tồn tại và đang được status on going
                //Kiểm tra xem list package nào trong request đang bị trùng
                //Trùng thì Update Booking Detail
                if (listContractAtApartmentId.Any())
                {
                    foreach (var item in listContractAtApartmentId)
                    {
                        // Kiểm tra xem có PackageId của Request có cái nào trùng với Pcakge của căn hộ đó đang
                        // Trong trạng thái on going hay không
                        // Và kiểm tra trạng thái is renew, bởi vì đối với từng lần đăng ký trùng, thì hệ thống sẽ
                        // Cập nhật lại hệ isrenew cho booking detail, nên chỉ kiếm những Booking detail nào có is renew bằng False
                        // Nếu có thì cập nhật cái trạng thái 
                        if (request.ListPackage.Select(x => x.PackageId).ToList().Contains(item.PackageId.ToString()) &&
                                                                                           item.BookingDetailStatus == 0 &&
                                                                                           !item.IsRe_Newed)
                        {
                            var updateBookingDetail = new UpdateBookingDetailNewCommand
                            {
                                BookingDetailId = item.BookingdetailId,
                                RenewStartDate = request.StartDate,
                            };
                            var updateBookingDetailResponse = await _mediator.Send(updateBookingDetail);
                        }
                    }
                }
                foreach (var item in request.ListPackage)
                {
                    var startDate = request.StartDate;
                    if (listContractAtApartmentId.Any() &&
                        listContractAtApartmentId.Select(x => x.PackageId).ToList().Contains(Guid.Parse(item.PackageId)))
                    {
                        var check = listContractAtApartmentId.Where(x => x.PackageId == Guid.Parse(item.PackageId) &&
                                                                         x.BookingDetailStatus == 0 &&
                                                                         !x.IsRe_Newed).SingleOrDefault();
                        if (check != null)
                        {
                            //Thực hiện việc insert ở toàn bộ ở đây
                            var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(item.PackageId)).SingleAsync();
                            var createBookingDetailRequest = new CreateBookingDetailCommand
                            {
                                BookingId = booking.Id,
                                PackageId = Guid.Parse(item.PackageId),
                                QuantityOfPackageOrdered = item.QuantityOfPackageOrdered,
                                StartDate = GetLastDateOfBookingOlder(check),
                                CreateBy = request.CreateBy,

                            };
                            var createBookingDetailResponse = await _mediator.Send(createBookingDetailRequest);
                        }
                    }
                    else
                    {
                        //Thực hiện việc insert ở toàn bộ ở đây
                        var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(item.PackageId)).SingleAsync();
                        var createBookingDetailRequest = new CreateBookingDetailCommand
                        {
                            BookingId = booking.Id,
                            PackageId = Guid.Parse(item.PackageId),
                            QuantityOfPackageOrdered = item.QuantityOfPackageOrdered,
                            StartDate = request.StartDate,
                            CreateBy = request.CreateBy,

                        };
                        var createBookingDetailResponse = await _mediator.Send(createBookingDetailRequest);
                    }
                }
                scope.Complete();
            }
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }
        private string CreateContractByApartmentId(string ApartmentId)
        {
            var user = (from st in _dbContext.Student
                        join apart in _dbContext.Apartment
                        on st.Id equals apart.StudentId
                        where apart.Id == Guid.Parse(ApartmentId)
                        select st.ApplicationUser.FullName).FirstOrDefault();
            return "Hợp đồng " + (user != null ? user.Trim() : "") + " " + DateTime.Now.ToString("yyyy/MM/dd");
        }
        private DateTime GetLastDateOfBookingOlder(ContractAtApartment oldContract)
        {
            var attendReport = _dbContext.AttendReport.Where(x => x.BookingDetailId == oldContract.BookingdetailId).OrderByDescending(x => x.DateDoPackage).Single();
            var lastDate = attendReport.DateDoPackage;
            return lastDate;
        }
    }

    #region ContractAtApartment
    public class ContractAtApartment
    {
        public Guid BookingdetailId { get; set; }
        public Guid ApartmentId { get; set; }
        public Guid PackageId { get; set; }
        public string? PackageName { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsRe_Newed { get; set; }
        public int BookingDetailStatus { get; set; }
    }
    #endregion
}
