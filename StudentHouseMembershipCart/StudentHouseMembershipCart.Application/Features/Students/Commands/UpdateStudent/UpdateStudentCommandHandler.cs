using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Unit>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _context.Student.Include(s => s.ApplicationUser).FirstOrDefaultAsync(s => s.Id == request.StudentId);
            if (student == null)
            {
                throw new NotFoundException("Student does not exist !");
            }
            else if (student.IsDelete == true)
            {
                throw new NotFoundException("The student have been deleted");
            }

            var validator = new UpdateStudentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Invalid Customer", validationResult);
            }

            student.Phone = request.Phone;
            student.Birthday = request.Birthday;
            student.Address = request.Address;

            if (student.ApplicationUser != null)
            {
                student.ApplicationUser.FullName = request.FullName;
            }
            _context.Student.Update(student);
            await _context.SaveChangesAsync();

            var user = await _userManager.FindByIdAsync(student.ApplicationUser.Id);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                // Xóa role hiện tại
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                //Add role mới vào
                await _userManager.AddToRoleAsync(user, "Student");
            }

            return Unit.Value;
        }
    }
}