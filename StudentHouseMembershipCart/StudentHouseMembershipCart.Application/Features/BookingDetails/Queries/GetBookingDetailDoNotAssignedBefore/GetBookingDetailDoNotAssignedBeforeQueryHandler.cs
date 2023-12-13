/*using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailDoNotAssignedBefore
{
    public class GetBookingDetailDoNotAssignedBeforeQueryHandler : IRequestHandler<GetBookingDetailDoNotAssignedBeforeQuery, List<BookingDetailDoNotAssignedBeforeData>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public GetBookingDetailDoNotAssignedBeforeQueryHandler(IApplicationDbContext dbContext, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<List<BookingDetailDoNotAssignedBeforeData>> Handle(GetBookingDetailDoNotAssignedBeforeQuery request, CancellationToken cancellationToken)
        {
            List<BookingDetailDoNotAssignedBeforeData> response = new List<BookingDetailDoNotAssignedBeforeData>();
            var bookingDetail = await _dbContext.BookingDetail.Where(x => x.BookingDetailStatus != 1).OrderBy(x => x.Created).ToListAsync();
            var bookingDetailStaff = await _dbContext.BookingDetailStaff.ToListAsync();
            foreach (var item in bookingDetail)
            {
                var data = bookingDetailStaff.Where(x => x.BookingDetailId == item.Id).FirstOrDefault();
                if (data == null)
                {
                    var date = item.Created.ToString("dd/MM/yyyy");
                    var packageName = _dbContext.Package.Where(x => x.Id == item.PackageId).Select(x => x.PackageName).FirstOrDefault();
                    var studentInfor = await (from b in _dbContext.Booking

                                              join a in _dbContext.Apartment
                                              on b.ApartmentId equals a.Id

                                              join s in _dbContext.Student
                                              on a.StudentId equals s.Id

                                              where b.Id == item.BookingId

                                              select s.ApplicationUserId).FirstOrDefaultAsync();
                    var applicationUser = await _userManager.FindByIdAsync(studentInfor);
                    var studentName = applicationUser.FullName;
                    var nameBookingdetail = "Booking Details Of " + studentName + " " + packageName + " " + date;
                    var bdd = _mapper.Map<BookingDetailDoNotAssignedBeforeData>(item);
                    if (item.BookingDetailStatus == 0)
                    {
                        bdd.BookingDetailStatus = "On going";
                    }
                    else if (item.BookingDetailStatus == 1)
                    {
                        bdd.BookingDetailStatus = "Finished";
                    }
                    else
                    {
                        bdd.BookingDetailStatus = "Finished";
                    }
                    bdd.BookingDetailName = nameBookingdetail;
                    response.Add(bdd);
                }
            }
            return response;
        }
    }
}*/