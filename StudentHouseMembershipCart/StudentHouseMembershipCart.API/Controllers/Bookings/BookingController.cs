using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Application.Features.Bookings.Commands.CreateBooking;
using StudentHouseMembershipCart.Application.Features.Categories.Commands.CreateCategory;
using StudentHouseMembershipCart.Application.Features.Categories.Queries.ReadAllCategories;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.Bookings;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetAllBooking;
using StudentHouseMembershipCart.Application.Features.Bookings.Queries.GetBookingsByApartmentId;

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
        [HttpPost]
        [Route("bookings")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SHMResponse> CreateBooking(CreateBookingCommand request)
        {
            return await _mediator.Send(request);
        }
        [HttpGet]
        public async Task<List<BookingData>> GetAllBooking()
        {
            return await _mediator.Send(new GetAllBookingCommand());
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
    }
}
