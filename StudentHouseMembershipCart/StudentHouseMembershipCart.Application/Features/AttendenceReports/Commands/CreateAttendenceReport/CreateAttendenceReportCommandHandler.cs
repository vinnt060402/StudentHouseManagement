using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport
{
    public class CreateAttendenceReportCommandHandler : IRequestHandler<CreateAttendenceReportCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;

        public CreateAttendenceReportCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SHMResponse> Handle(CreateAttendenceReportCommand request, CancellationToken cancellationToken)
        {
            DateTime startDate = new DateTime(request.StartDay.Year, request.StartDay.Month, request.StartDay.Day);
            int totalDaysA = request.TotalDayNeedWork;
            int workDaysPerWeekA = request.TotalDayWorkingInWeek;
            string workDaysA = request.DayDoBookingDetailInWeek;

            List<DateTime> attendanceDates = GenerateAttendanceDates(startDate, totalDaysA, workDaysPerWeekA, workDaysA);

            var listAttendenceReport = new List<AttendReport>();
            foreach (var dateDo in attendanceDates)
            {
                var attendenceReport = new AttendReport
                {
                    DateDoPackage = dateDo,
                    BookingDetailId = Guid.Parse(request.BookingDetailId),
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

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
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
    }
}
