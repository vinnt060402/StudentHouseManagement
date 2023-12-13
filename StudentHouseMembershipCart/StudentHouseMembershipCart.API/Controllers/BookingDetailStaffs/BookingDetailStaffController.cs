using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.BookingDetailStaffs.Commands.CreateBookingDetailStaff;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff;
using StudentHouseMembershipCart.Infrastucture.EmailService;

namespace StudentHouseMembershipCart.API.Controllers.BookingDetailStaffs
{
    [Route("api/v1/bookingdetailstaff")]
    [ApiController]
    public class BookingDetailStaffController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IEmailServiceTest _email;

        public BookingDetailStaffController(IMediator mediator, IEmailServiceTest email)
        {
            _mediator = mediator;
            _email = email;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateBookingDetailStaff(CreateBookingDetailStaffCommand request)
        {
            var response = await _mediator.Send(request);
            var getStaff = await _mediator.Send(new GetStaffQuery()
            {
                Id = request.StaffId
            });
            if(getStaff != null)
            {
                try
                {
                    _email.SendEmailInfoStaffHavebeenAssign(getStaff.staffData!.Id, getStaff.staffData.staffName!, getStaff.inforOfStaffData!.Email!);
                    return response;
                }
                catch
                {
                    return response;
                }
            }
            return response;
        }
    }
}