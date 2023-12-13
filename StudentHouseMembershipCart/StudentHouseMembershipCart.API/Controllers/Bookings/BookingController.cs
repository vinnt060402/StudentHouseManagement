using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingAndBookingDetailByBookingId;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByStudentId;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingByTimeOfAdmin;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingsByApartmentId;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetAllBookingDoNotAssignBefore;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByStudentId;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByTimeOfAdmin;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStaffId;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetServiceOfBookingDetailByStudentId;

namespace StudentHouseMembershipCart.API.Controllers.Bookings
{
    [Route("api/v1/bookings")]
    [ApiController]
    public class BookingController
    {
        private readonly IMediator _mediator;

        public BookingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<BookingDataNew>> GetAllBooking()
        {
            return await _mediator.Send(new GetAllBookingNewCommand());
        }
        [HttpGet]
        [Route("attendsdonotassignbefore")]
        public async Task<List<BookingDetailDoNotAssignBeforeData>> GetAllBookingDetailDoNotAssignBefore()
        {
            return await _mediator.Send(new GetAllBookingDoNotAssignBeforeQuery());
        }
        [HttpGet]
        [Route("datetime")]
        public async Task<BookingDataForAdminNew> GetAllPackagesByTimeOfAdmin([FromQuery] GetBookingByTimeOfAdminNewQuery request)
        {
            return await _mediator.Send(request);
        }
        [HttpGet]
        [Route("students/{studentid}")]
        public async Task<List<BookingDataNew>> GetBookingByStudentId(string studentid)
        {
            var request = new GetBookingByStudentIdNewCommand()
            {
                StudentId = Guid.Parse(studentid)
            };
            return await _mediator.Send(request);
        }

        [HttpGet]
        [Route("serviceOfbookingdetails/{studentid}")]
        public async Task<List<ServiceOfBookingDetail>> GetServiceOfBookingDetail(string studentid)
        {
            var request = new GetServiceOfBookingDetailByStudentIdCommand()
            {
                StudentId = Guid.Parse(studentid)
            };
            return await _mediator.Send(request);
        }
        [HttpGet]
        [Route("serviceOfbookingdetails/staffs/{staffid}")]
        public async Task<List<ServiceOfBookingDetailOfStaff>> GetServiceOfBookingDetailByStaffId(string staffid)
        {
            var request = new GetServiceOfBookingDetailByStaffIdQuery
            {
                StaffId = Guid.Parse(staffid)
            };
            return await _mediator.Send(request);
        }
    }
}