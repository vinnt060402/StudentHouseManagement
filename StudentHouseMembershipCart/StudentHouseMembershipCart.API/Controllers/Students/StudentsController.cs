using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent;
using StudentHouseMembershipCart.Application.Features.Students.Commands.DeleteStudent;
using StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentById;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetTotalStudentRegister;
using StudentHouseMembershipCart.Domain.Entities;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentHouseMembershipCart.API.Controllers.Students
{
    [Route("api/v1/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-student")]
        public async Task<List<Application.Features.Students.Queries.GetAllStudent.StudentResponse>> GetAllStudent()
        {
            var response = await _mediator.Send(new GetListStudentQuery());
            return response;
        }

        [HttpGet]
        [Route("gettotalstudentregistered")]
        public async Task<TotalStudentRegistered> GetTotalStudent()
        {
            var response = await _mediator.Send(new GetTotalStudentRegisteredQuery());
            return response;
        }
        // GET: api/<StudentsController>
        [HttpPost]
        [Route("register-student")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateStudent(CreateStudentCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllStudent), new { id = response });
        }

        [HttpDelete]
        [Route("delete-student-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(DeleteStudentCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // POST api/<StudentsController>
        [HttpPut]
        [Route("update-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<StudentDto>> UpdateCustomer(UpdateStudentCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok("Update Customer Successfully");
        }

        [HttpGet]
        [Route("get-student-by-id")]
        public async Task<ActionResult<StudentDto>> GetUserById([FromQuery] GetStudentByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet]
        [Route("studentid")]
        public async Task<ActionResult<StudentDataNew>> GetUserByStudentId([FromQuery] GetStudentByStudentIdCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}