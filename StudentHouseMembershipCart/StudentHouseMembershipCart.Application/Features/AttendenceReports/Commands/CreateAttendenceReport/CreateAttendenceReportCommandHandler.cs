using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.AttendenceReports.Commands.CreateAttendenceReport
{
    public class CreateAttendenceReportCommandHandler : IRequestHandler<CreateAttendenceReportCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;

        public CreateAttendenceReportCommandHandler(IApplicationDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public async Task<SHMResponse> Handle(CreateAttendenceReportCommand request, CancellationToken cancellationToken)
        {
            var aRCheck = await _dbContext.AttendReport.Where(x => x.ServiceId == Guid.Parse(request.ServiceId) &&
                                                             x.BookingDetailId == Guid.Parse(request.BookingDetailId) &&
                                                             x.AttendReportForType == request.BookingDetailType).ToListAsync();
            var listCheckInt = new List<int>();
            int numFlag = 0;
            if (aRCheck != null)
            {
                var titleNumber = aRCheck.Select(x => x.AttendTittle).ToList();
                foreach (var item in titleNumber)
                {
                    var getlast3character = item!.Substring(item.Length - 3);
                    if (getlast3character != null)
                    {
                        int number = int.Parse(getlast3character.Split('(')[1].Split(')')[0]);
                        listCheckInt.Add(number);
                    }

                }
            }
            if (listCheckInt.Any())
            {
                numFlag = listCheckInt.Max();
            }

            var service = await _dbContext.Service.Where(x => x.Id == Guid.Parse(request.ServiceId)).SingleOrDefaultAsync();
            //Local Variable
            BookingDetailOfPakcage bookingDetailPackage = new BookingDetailOfPakcage();
            BookingDetailOfService bookingDetailService = new BookingDetailOfService();


            DateTime EndDateCheck = DateTime.Now;

            if (request.BookingDetailType == "1")
            {
                var bookingDetail = await _dbContext.BookingDetailOfPakcage.Where(x => x.Id == Guid.Parse(request.BookingDetailId)).SingleOrDefaultAsync();
                if (bookingDetail != null)
                {
                    bookingDetailPackage = bookingDetail;
                }
                EndDateCheck = bookingDetail!.EndDate! ?? DateTime.Now;
            }
            else if (request.BookingDetailType == "2")
            {
                var bookingDetail = await _dbContext.BookingDetailOfService.Where(x => x.Id == Guid.Parse(request.BookingDetailId)).SingleOrDefaultAsync();
                if (bookingDetail != null)
                {
                    bookingDetailService = bookingDetail;
                }
                EndDateCheck = bookingDetail!.EndDate! ?? DateTime.Now;
            }
            var serviceTaskRemain = await _dbContext.ServiceRemainingTaskDuration.Where(x => x.BookingDetailId == Guid.Parse(request.BookingDetailId) &&
                                                                                             x.ServiceId == Guid.Parse(request.ServiceId) &&
                                                                                             x.AttendReportForType == request.BookingDetailType).SingleOrDefaultAsync();
            if (serviceTaskRemain == null)
            {
                throw new BadRequestException("Remaining Task Duration Is Not Found So can not create Attend for you!!");
            }

            if (request.QuantityDoService > serviceTaskRemain.RemainingTaskDuration)
            {
                throw new BadRequestException("Remaining Task Duration Is Not Enough For Your Create Attend!!");
            }

/*            var flagCheckDate = DateTime.Compare(DateTime.Now, request.DateDoService) >= 0;
            //Nếu ngày chọn nhỏ hơn hoặc bằng ngày hiện tại thì không được
            if (flagCheckDate)
            {
                throw new BadRequestException("Date do service can not later than date time now");
            }
            //Nếu ngày chọn lớn hơn EndDate của bookingDetail thì không được
            flagCheckDate = DateTime.Compare(EndDateCheck, request.DateDoService) < 0;
            if (flagCheckDate)
            {
                throw new BadRequestException("Service date cannot be less than the end date");
            }*/
            Guid StudentId;
            if (request.BookingDetailType == "1")
            {
                StudentId = await (from bdP in _dbContext.BookingDetailOfPakcage

                                   join b in _dbContext.Booking

                                   on bdP.BookingId equals b.Id

                                   join a in _dbContext.Apartment

                                   on b.ApartmentId equals a.Id

                                   select a.StudentId).FirstOrDefaultAsync();
            }
            else
            {
                StudentId = await (from bdS in _dbContext.BookingDetailOfService

                                   join b in _dbContext.Booking

                                   on bdS.BookingId equals b.Id

                                   join a in _dbContext.Apartment

                                   on b.ApartmentId equals a.Id

                                   select a.StudentId).FirstOrDefaultAsync();
            }
            /*
             * Handle chu kỳ làm việc
             * Chu kỳ là việc chúng ta sẽ thực hiện Service đó trong khoản thời gian chu kỳ
             * Ví dụ như hôm nay là thứ 6, chọn chu kỳ 7 ngày thì chúng ta sẽ là cái service đó 2 lần (thứ 6 tuần 1 - thứ 6 tuần 2)
             * Ví dụ như hôm nay là thứ 6, chọn chu kỳ 30 ngày thì chúng ta sẽ làm cái service đó 4 lần 
             * ( thứ 6 tuần 1 - thứ 6 tuần 2 - thứ 6 tuần 3 - thứ 6 tuần 4)
             * Tương tự cho các loại chu kỳ còn lại
            */
            var listDateDoService = HandleCreateListTimeDoService(request.DateDoService, EndDateCheck, request.WorkingCycle, request.FrequencyDaysPerOccurrence, request.QuantityDoService, serviceTaskRemain.RemainingTaskDuration);
            if (serviceTaskRemain != null)
            {
                serviceTaskRemain.RemainingTaskDuration = serviceTaskRemain.RemainingTaskDuration - listDateDoService.Count * request.QuantityDoService;
                _dbContext.ServiceRemainingTaskDuration.Update(serviceTaskRemain);
            }
            if (numFlag == 0)
            {
                numFlag = 1;
            }
            else
            {
                numFlag++;
            }
            foreach (var item in listDateDoService)
            {
                //Tạo AttendReport
                var aR = new AttendReport()
                {
                    AttendTittle = "Work for Service " + service!.ServiceName!.Trim() + ", Date: " + item.ToString("yyyy/MM/dd HH:mm") + " " + "(" + numFlag.ToString() + ")",
                    DateDoService = item,
                    ServiceId = Guid.Parse(request.ServiceId),
                    BookingDetailId = Guid.Parse(request.BookingDetailId),
                    AttendReportForType = request.BookingDetailType,
                    AttendenceStatus = 0,
                    Note = request.Note + " Quantity to do: " + request.QuantityDoService,
                };

                _dbContext.AttendReport.Add(aR);

                var feedback = new FeedBack()
                {
                    FeedBackStatus = 0,
                    StudentId = StudentId,
                    AttendReportId = aR.Id
                };
                _dbContext.FeedBack.Add(feedback);
                //TODO Tạo Handle tạo Task cho nhân viên -> từ Task sẽ có ReportWork + Feedback
            }

            await _dbContext.SaveChangesAsync();
            return new SHMResponse
            {
                Message = Extensions.CreateSuccessfully
            };
        }

        private List<DateTime> HandleCreateListTimeDoService(DateTime DateDoService, DateTime EndDate, int WorkingCycle, int FrequencyDaysPerOccurrence, int quantityDoService, int reaminingTaskDuration)
        {
            List<DateTime> list = new List<DateTime>();
            int i = 0;
            int flagCheckQuantityAfterDo = reaminingTaskDuration;
            do
            {
                if (WorkingCycle == 1)
                {
                    list.Add(DateDoService);
                    flagCheckQuantityAfterDo = flagCheckQuantityAfterDo - quantityDoService;
                    if (flagCheckQuantityAfterDo < 0)
                    {
                        throw new BadRequestException("The remaining amount of service is not enough");
                    }
                    break;
                }
                //Add ngày đầu tiên vào list vì nó luôn là ngày hợp lệ
                if (!list.Any())
                {
                    list.Add(DateDoService);
                }
                //Theo BR thì luôn + 7 ngày
                DateDoService = DateDoService.AddDays(FrequencyDaysPerOccurrence);
                if (DateDoService > EndDate)
                {
                    break;
                }
                else
                {
                    flagCheckQuantityAfterDo = flagCheckQuantityAfterDo - quantityDoService;
                    if (flagCheckQuantityAfterDo < 0)
                    {
                        break;
                    }
                    list.Add(DateDoService);
                    i += FrequencyDaysPerOccurrence;
                }
            } while (i < WorkingCycle);
            return list;
        }
    }
}