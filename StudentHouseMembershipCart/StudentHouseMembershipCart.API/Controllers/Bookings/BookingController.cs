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
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByStudentId;
using StudentHouseMembershipCart.Application.Features.Bookings.QueriesNew.GetBookingByTimeOfAdmin;

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
        /*[HttpPost]
        [Route("bookings")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateBooking(CreateBookingCommand request)
        {
            return await _mediator.Send(request);
        }*/
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateNewBookingCommand(CreateNewBookingCommand request)
        {
            return await _mediator.Send(request);
        }

        /*[HttpGet]
        public async Task<List<BookingData>> GetAllBooking()
        {
            return await _mediator.Send(new GetAllBookingCommand());
        }
        [HttpGet]
        [Route("datetime")]
        public async Task<BookingDataForAdmin> GetAllPackagesByTimeOfAdmin([FromQuery] GetBookingByTimeOfAdminQuery request)
        {
            return await _mediator.Send(request);
        }*/
        [HttpGet]
        public async Task<List<BookingDataNew>> GetAllBooking()
        {
            return await _mediator.Send(new GetAllBookingNewCommand());
        }
        [HttpGet]
        [Route("datetime")]
        public async Task<BookingDataForAdminNew> GetAllPackagesByTimeOfAdmin([FromQuery] GetBookingByTimeOfAdminNewQuery request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [Route("{apartmentId}")]
        public async Task<List<BookingData>> GetBookingByApartmentId(string apartmentId)
        {
            var request = new GetBookingsByApartmentIdCommand
            {
                ApartmentId = apartmentId
            };

            return await _mediator.Send(request);
        }
        [HttpGet]
        [Route("bookingid")]
        public async Task<BookingData> GetBookingByBookingId([FromQuery] GetBookingAndBookingDetailByBookingIdCommand request)
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
    }
}