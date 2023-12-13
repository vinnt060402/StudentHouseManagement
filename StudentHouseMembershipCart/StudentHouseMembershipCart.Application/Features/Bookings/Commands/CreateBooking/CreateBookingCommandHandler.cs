/*using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.CreateBookingDetail;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetailNew;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage.Queries.ReadFPById;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Commands.CreateFeedBack;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Commands.CreatePaymentHistory;
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
            try
            {
                var listPakageData = new List<Package>();
                foreach (var item in request.ListPackage.Select(x => x.PackageId).ToList())
                {
                    var package = await _dbContext.Package.Where(x => x.Id == Guid.Parse(item)).SingleOrDefaultAsync();
                    listPakageData.Add(package);
                }
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var apartment = await _dbContext.Apartment.Where(x => x.Id == Guid.Parse(request.ApartmentId)).SingleOrDefaultAsync();
                    var studentId = apartment.StudentId.ToString();
                    //Đầu tiên kiểm tra xem ở căn hộ đó đã có họp đồng nào hay chưa
                    //Kiểm tra xem trong họp đồng đó nó đã có những package id nào
                    //Nếu trùng với bất kì package nào trong hợp đồng đã có thì
                    //Tiến hành thêm ngày vào trong hợp đồng đó
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
                        var getPackageIdRequest = listPakageData.Where(x => x.Id == Guid.Parse(package)).FirstOrDefault(); *//*new GetPackageByIdCommand
                        {
                            PakageId = package
                        };

                        var getPackageIdResponse = await _mediator.Send(getPackageIdRequest);*//*
                        var priceOfPackage = getPackageIdRequest.TotalPrice * request.ListPackage.Where(x => x.PackageId == package).Select(x => x.QuantityOfPackageOrdered).FirstOrDefault();
                        totalPrice += priceOfPackage ?? 0;
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
                    //await _dbContext.SaveChangesAsync();
                    Task.WaitAll();
                    //Tạo payment history
                    var createPaymentHistory = new CreatePaymentHistoryCommand
                    {
                        BookingId = booking.Id,
                        Amount = totalPrice,
                        CreateBy = request.CreateBy,
                        PaymentMethodId = Guid.Parse(request.PaymentMethodId),
                        PaymentStatus = 1
                    };
                    var createPaymentHistoryResponse = await _mediator.Send(createPaymentHistory);
                    Task.WaitAll();

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
                            if (request.ListPackage.Select(x => x.PackageId).ToList().Contains(item.PackageId.ToString().ToUpper()) &&
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
                        var package = listPakageData.Where(x => x.Id == Guid.Parse(item.PackageId)).SingleOrDefault();

                        if (listContractAtApartmentId.Any() &&
                            listContractAtApartmentId.Select(x => x.PackageId).ToList().Contains(Guid.Parse(item.PackageId)))
                        {
                            var check = listContractAtApartmentId.Where(x => x.PackageId == Guid.Parse(item.PackageId) &&
                                                                             x.BookingDetailStatus == 0 &&
                                                                             !x.IsRe_Newed).FirstOrDefault();
                            if (check != null)
                            {
                                var packageDataRequest = listPakageData.Where(x => x.Id == Guid.Parse(item.PackageId)).First();
                                //Thực hiện việc insert ở toàn bộ ở đây
                                #region Create Booking Detail
                                var createBookingDetailRequest = new CreateBookingDetailCommand
                                {
                                    StudentId = Guid.Parse(studentId),
                                    BookingId = booking.Id,
                                    PackageId = Guid.Parse(item.PackageId),
                                    PackageDataRequest = listPakageData.Where(x => x.Id == Guid.Parse(item.PackageId)).FirstOrDefault(),
                                    QuantityOfPackageOrdered = item.QuantityOfPackageOrdered,
                                    StartDate = GetLastDateOfBookingOlder(check),
                                    CreateBy = request.CreateBy,

                                };
                                var packageInCreateBookingDetail = packageDataRequest;

                                if (packageInCreateBookingDetail.IsDelete)
                                {
                                    throw new NotFoundException("Some package does not existed or was deleted before!!");
                                }
                                // Calc total day of work 
                                var remainingtaskDuration = packageInCreateBookingDetail.NumberOfPerWeekDoPackage * packageInCreateBookingDetail.WeekNumberBooking * createBookingDetailRequest.QuantityOfPackageOrdered;
                                // Calc price of booking detail
                                var price = item.QuantityOfPackageOrdered * packageInCreateBookingDetail.TotalPrice;
                                var bookdingDetail = new BookingDetail
                                {
                                    TotalPriceOfQuantity = price ?? 0,
                                    RemainingTaskDuration = remainingtaskDuration ?? 0,
                                    IsRe_Newed = false,
                                    RenewStartDate = null,
                                    BookingDetailStatus = 0,
                                    BookingId = createBookingDetailRequest.BookingId,
                                    PackageId = createBookingDetailRequest.PackageId,
                                    CreateBy = createBookingDetailRequest.CreateBy,
                                    QuantityOfPackageOrdered = createBookingDetailRequest.QuantityOfPackageOrdered ?? 0,
                                };
                                _dbContext.BookingDetail.Add(bookdingDetail);
                                #endregion

                                #region Create attendence report !!!
                                var createAttenceReportRequest = new CreateAttendenceReportCommand
                                {
                                    StudentId = createBookingDetailRequest.StudentId,
                                    BookingDetailId = bookdingDetail.Id.ToString(),
                                    StartDay = createBookingDetailRequest.StartDate,
                                    TotalDayNeedWork = bookdingDetail.RemainingTaskDuration,
                                    TotalDayWorkingInWeek = packageInCreateBookingDetail.NumberOfPerWeekDoPackage,
                                    DayDoBookingDetailInWeek = packageInCreateBookingDetail.DayDoServiceInWeek,
                                };
                                #region Create Attend Report

                                DateTime startDateInCreate = new DateTime(createAttenceReportRequest.StartDay.Year, createAttenceReportRequest.StartDay.Month, createAttenceReportRequest.StartDay.Day);
                                int totalDaysA = createAttenceReportRequest.TotalDayNeedWork;
                                int workDaysPerWeekA = createAttenceReportRequest.TotalDayWorkingInWeek;
                                string workDaysA = createAttenceReportRequest.DayDoBookingDetailInWeek;

                                List<DateTime> attendanceDates = GenerateAttendanceDates(startDateInCreate, totalDaysA, workDaysPerWeekA, workDaysA);

                                var listAttendenceReport = new List<AttendReport>();
                                foreach (var dateDo in attendanceDates)
                                {
                                    var attendenceReport = new AttendReport
                                    {
                                        DateDoPackage = dateDo,
                                        BookingDetailId = Guid.Parse(createAttenceReportRequest.BookingDetailId),
                                        ReportWorkId = null,
                                        AttendenceStatus = 0,
                                        IsDelete = false,
                                    };
                                    listAttendenceReport.Add(attendenceReport);
                                }
                                _dbContext.AttendReport.AddRange(listAttendenceReport);
                                try
                                {
                                    foreach (var dateDo in listAttendenceReport)
                                    {
                                        var createFeedback = new CreateFeedBackCommand
                                        {
                                            AttendReportId = dateDo.Id,
                                            StudentId = createAttenceReportRequest.StudentId,
                                            CreateBy = dateDo.CreateBy
                                        };
                                        var feedback = new FeedBack()
                                        {
                                            StudentId = createFeedback.StudentId,
                                            AttendReportId = createFeedback.AttendReportId,
                                            FeedBackStatus = 0,
                                            CreateBy = createFeedback.CreateBy
                                        };
                                        _dbContext.FeedBack.Add(feedback);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new BadRequestException(ex.StackTrace);
                                }
                                #endregion
                                #endregion
                            }
                        }
                        else
                        {
                            //Thực hiện việc insert ở toàn bộ ở đây
                            #region Create Booking Detail
                            var createBookingDetailRequest = new CreateBookingDetailCommand
                            {
                                StudentId = Guid.Parse(studentId),
                                BookingId = booking.Id,
                                PackageId = Guid.Parse(item.PackageId),
                                PackageDataRequest = listPakageData.Where(x => x.Id == Guid.Parse(item.PackageId)).FirstOrDefault(),
                                QuantityOfPackageOrdered = item.QuantityOfPackageOrdered,
                                StartDate = request.StartDate,
                                CreateBy = request.CreateBy,

                            };
                            var packageInCreateBookingDetail = createBookingDetailRequest.PackageDataRequest;

                            if (packageInCreateBookingDetail.IsDelete)
                            {
                                throw new NotFoundException("Some package does not existed or was deleted before!!");
                            }
                            // Calc total day of work 
                            var remainingtaskDuration = packageInCreateBookingDetail.NumberOfPerWeekDoPackage * packageInCreateBookingDetail.WeekNumberBooking * createBookingDetailRequest.QuantityOfPackageOrdered;
                            // Calc price of booking detail
                            var price = createBookingDetailRequest.QuantityOfPackageOrdered * packageInCreateBookingDetail.TotalPrice;
                            var bookdingDetail = new BookingDetail
                            {
                                TotalPriceOfQuantity = price ?? 0,
                                RemainingTaskDuration = remainingtaskDuration ?? 0,
                                IsRe_Newed = false,
                                RenewStartDate = null,
                                BookingDetailStatus = 0,
                                BookingId = createBookingDetailRequest.BookingId,
                                PackageId = createBookingDetailRequest.PackageId,
                                CreateBy = createBookingDetailRequest.CreateBy
                            };
                            _dbContext.BookingDetail.Add(bookdingDetail);
                            #endregion

                            //TODO Create attendence report !!!
                            var createAttenceReportRequest = new CreateAttendenceReportCommand
                            {
                                StudentId = createBookingDetailRequest.StudentId,
                                BookingDetailId = bookdingDetail.Id.ToString(),
                                StartDay = createBookingDetailRequest.StartDate,
                                TotalDayNeedWork = bookdingDetail.RemainingTaskDuration,
                                TotalDayWorkingInWeek = packageInCreateBookingDetail.NumberOfPerWeekDoPackage,
                                DayDoBookingDetailInWeek = packageInCreateBookingDetail.DayDoServiceInWeek,
                            };
                            #region Create Attend Report

                            DateTime startDateInCreate = new DateTime(createAttenceReportRequest.StartDay.Year, createAttenceReportRequest.StartDay.Month, createAttenceReportRequest.StartDay.Day);
                            int totalDaysA = createAttenceReportRequest.TotalDayNeedWork;
                            int workDaysPerWeekA = createAttenceReportRequest.TotalDayWorkingInWeek;
                            string workDaysA = createAttenceReportRequest.DayDoBookingDetailInWeek;

                            List<DateTime> attendanceDates = GenerateAttendanceDates(startDateInCreate, totalDaysA, workDaysPerWeekA, workDaysA);

                            var listAttendenceReport = new List<AttendReport>();
                            foreach (var dateDo in attendanceDates)
                            {
                                var attendenceReport = new AttendReport
                                {
                                    DateDoPackage = dateDo,
                                    BookingDetailId = Guid.Parse(createAttenceReportRequest.BookingDetailId),
                                    ReportWorkId = null,
                                    AttendenceStatus = 0,
                                    IsDelete = false,
                                };
                                listAttendenceReport.Add(attendenceReport);
                            }
                            _dbContext.AttendReport.AddRange(listAttendenceReport);
                            try
                            {
                                await _dbContext.SaveChangesAsync();
                                foreach (var dateDo in listAttendenceReport)
                                {
                                    var createFeedback = new CreateFeedBackCommand
                                    {
                                        AttendReportId = dateDo.Id,
                                        StudentId = createAttenceReportRequest.StudentId,
                                        CreateBy = dateDo.CreateBy
                                    };
                                    var feedback = new FeedBack()
                                    {
                                        StudentId = createFeedback.StudentId,
                                        AttendReportId = createFeedback.AttendReportId,
                                        FeedBackStatus = 0,
                                        CreateBy = createFeedback.CreateBy
                                    };
                                    _dbContext.FeedBack.Add(feedback);
                                }
                            }
                            catch (Exception ex)
                            {
                                throw new BadRequestException(ex.StackTrace);
                            }
                            #endregion

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
        private DateTime GetLastDateOfBookingOlder(ContractAtApartment oldContract)
        {
            var attendReport = _dbContext.AttendReport.Where(x => x.BookingDetailId == oldContract.BookingdetailId).OrderByDescending(x => x.DateDoPackage).First();
            var lastDate = attendReport.DateDoPackage;
            return lastDate;
        }
        public List<DateTime> GenerateAttendanceDates(DateTime startDate, int totalDays, int workDaysPerWeek, string workDays)
        {
            // Chuyển đổi chuỗi workDays thành danh sách các ngày làm việc (workDaysArray).
            List<int> workDaysArray = workDays.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();

            // Tạo danh sách để lưu trữ các ngày điểm danh.
            List<DateTime> attendanceDates = new List<DateTime>();

            // Bắt đầu từ ngày sau ngày khởi đầu.
            DateTime currentDate = startDate.AddDays(1);

            // Lặp để tạo danh sách các ngày điểm danh cho đến khi đủ số ngày cần tạo.
            while (attendanceDates.Count < totalDays)
            {
                // Kiểm tra xem ngày hiện tại có nằm trong danh sách ngày làm việc không.
                if (workDaysArray.Contains((int)currentDate.DayOfWeek + 1))
                {
                    attendanceDates.Add(currentDate);
                }

                // Tăng ngày hiện tại lên 1.
                currentDate = currentDate.AddDays(1);

                // Nếu đã đủ một tuần làm việc (workDaysPerWeek ngày), thì điều chỉnh ngày tiếp theo.
                if (attendanceDates.Count % workDaysPerWeek == 0)
                {
                    currentDate = GetNextWorkDay(currentDate, workDaysArray);
                }
            }

            // Trả về danh sách các ngày điểm danh đã tạo.
            return attendanceDates;
        }

        // Phương thức để tìm ngày làm việc tiếp theo sau một ngày cụ thể.
        public DateTime GetNextWorkDay(DateTime currentDate, List<int> workDays)
        {
            do
            {
                currentDate = currentDate.AddDays(1);
            } while (!workDays.Contains((int)currentDate.DayOfWeek + 1));

            return currentDate;
        }
        #endregion
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
}*/