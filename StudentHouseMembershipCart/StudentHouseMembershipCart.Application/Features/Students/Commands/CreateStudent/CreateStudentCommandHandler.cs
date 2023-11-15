using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var emailExist = await _userManager.FindByEmailAsync(request.Email);
            if (emailExist != null)
            {
                throw new BadRequestException("The username already exists!");
            }

            /*var validator = new CreateStudentCommandValidator(_context);
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }*/

            var user = new ApplicationUser
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                FullName = request.FullName,
                EmailConfirmed = true,
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Student");
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            else
            {
                throw new BadRequestException("Account creation failed !");
            }
            var customer = new Student
            {
                /*Address = request.Address,
                Birthday = request.Birthday,
                Phone = request.Phone,*/
                ApplicationUserId = user.Id,
            };

            await _context.Student.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer.Id;
        }
    }
}