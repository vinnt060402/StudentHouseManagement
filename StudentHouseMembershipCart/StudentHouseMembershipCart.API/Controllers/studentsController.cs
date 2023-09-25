using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentAccountEmailPassword;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentHouseMembershipCart.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class studentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public studentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<studentsController>
        [HttpGet]
        [Route("getStudentByEmailPassword")]
        public async Task<StudentDto> GetUserDetail([FromQuery] GetStudent_ByEmailPasswordQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        // GET api/<studentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<studentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<studentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<studentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
