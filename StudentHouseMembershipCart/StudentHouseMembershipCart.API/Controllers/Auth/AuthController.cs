using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Constant;
using StudentHouseMembershipCart.Application.Contracts.Identity;
using StudentHouseMembershipCart.Application.Features.Auth.Queries.ChangePassword;
using StudentHouseMembershipCart.Application.Features.Auth.Queries.ResetPassword;
using StudentHouseMembershipCart.Application.Models.Identity;
using StudentHouseMembershipCart.Domain.IdentityModels;
using StudentHouseMembershipCart.Identity.Services;

namespace StudentHouseMembershipCart.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authenticationService;
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly RoleManager<IdentityRole> _roleManager;
        public readonly IConfiguration _configuration;
        private readonly IMediator _mediator;

        public AuthController(IAuthService authenticationService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IMediator mediator)
        {
            this._authenticationService = authenticationService;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._configuration = configuration;
            this._mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(AuthRequest request)
        {
            if (User.Identity.IsAuthenticated)
            {
                return BadRequest("You have logged in.");
            }
            var result = await _authenticationService.Login(request);
            var test = CustomSessionManager.GetString("username");
            return Ok(result);
        }

        [HttpPost("register-user")]
        public async Task<ActionResult<RegistrationResponse>> RegisterUser(RegistrationRequest request)
        {
            return Ok(await _authenticationService.Register(request, Extensions.Student));
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegistrationRequest request)
        {
            return Ok(await _authenticationService.Register(request, Extensions.Admin));
        }

        [HttpPost]
        [Route("register-staff")]
        public async Task<IActionResult> RegisterStaff([FromBody] RegistrationRequest request)
        {
            return Ok(await _authenticationService.Register(request, Extensions.Staff));
        }

        [HttpPost]
        [Route("reset-password")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordQuery request)
        {
            try
            {
                var result = await _mediator.Send(new ResetPasswordQuery { Email = request.Email });

                return Ok(result);
            }
            catch (Exception ex)
            {
                /*_logger.LogError(ex, "User not found");*/
                throw new BadRequestException("User does not exist.");
            }
        }

        [HttpPost]
        [Route("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordQuery request)
        {
            try
            {

                var result = await _mediator.Send(new ChangePasswordQuery
                {
                    Email = request.Email ?? "",
                    CurrentPassword = request.CurrentPassword ?? "",
                    NewPassword = request.NewPassword ?? ""
                });

                return Ok(result);
            }
            catch (Exception ex)
            {
                if (ex is ValidationException)
                {
                    ValidationException error = (ValidationException)ex;
                    var errorsDiction = new Dictionary<string, string[]>(error.Errors);
                    return BadRequest(errorsDiction);
                }
                return BadRequest(ex.Message);
            }
        }
    }
}