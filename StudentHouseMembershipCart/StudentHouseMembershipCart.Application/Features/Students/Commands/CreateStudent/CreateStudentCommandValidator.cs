using FluentValidation;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
    {
        private readonly IApplicationDbContext _context;
        public CreateStudentCommandValidator(/*IApplicationDbContext context*/)
        {
            /*_context = context;*/
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{UserName} is required")
                .NotNull()
                .MaximumLength(100).WithMessage("{UserName} must be fewer than 100 characters");
            /*.MustAsync(BeUniqueCustomerName).WithMessage("UserName already exist!");*/

            RuleFor(p => p.FullName)
                .NotEmpty().WithMessage("{FullName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{FullName} must be fewer than 20 characters");

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("Password is required")
                .NotNull()
                .MaximumLength(50).WithMessage("Password must be fewer than 50 characters")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).+$")
                .WithMessage("Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email is required")
                .NotNull()
                .MaximumLength(100).WithMessage("Email must be fewer than 100 characters")
                .Matches(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
                .WithMessage("Invalid email address");

            RuleFor(p => p.Phone)
                .Empty()
                .Null().When(p => p.Phone == null) // Kiểm tra giá trị null
                .WithMessage("Phone number can be null");
            RuleFor(p => p.Birthday)
                .Empty()
                .Null().When(p => p.Birthday == null) // Kiểm tra giá trị null
                .WithMessage("Phone number can be null");
            RuleFor(p => p.Address)
                .Empty()
                .Null().When(p => p.Address == null) // Kiểm tra giá trị null
                .WithMessage("Phone number can be null");


        }

        /*private async Task<bool> BeUniqueCustomerName(string customerName, CancellationToken token)
        {
            return await _context.Student.AllAsync(r => r.ApplicationUser.UserName == customerName) == false;
        }*/
    }
}