/*using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailByStaffId;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailDoNotAssignedBefore;

namespace StudentHouseMembershipCart.API.Controllers.BookingDetails
{
    [Route("api/v1/bookingdetail")]
    [ApiController]
    public class BookingDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<BookingDetailDoNotAssignedBeforeData>> GetBookingDetailDoNotAssignBefore()
        {
            return await _mediator.Send(new GetBookingDetailDoNotAssignedBeforeQuery());
        }
        [HttpGet]
        [Route("staffs/{id}")]
        public async Task<List<BookingDetailByStaffIdModel>> GetBookingDetailByStaffId(string id)
        {
            return await _mediator.Send(new GetBookingDetailByStaffIdQuery()
            {
                StaffId = id
            });
        }
    }
}*/