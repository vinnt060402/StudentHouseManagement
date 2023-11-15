using FluentValidation;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff
{
    public class CreateStaffRequestValidator : AbstractValidator<CreateStaffRequest>
    {
        public CreateStaffRequestValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage("{UserName} is required")
                .NotNull()
                .MaximumLength(100).WithMessage("{UserName} must be fewer than 100 characters");

            RuleFor(p => p.FullName)
                .NotEmpty().WithMessage("{FullName} is required")
                .NotNull()
                .MaximumLength(20).WithMessage("{FullName} must be fewer than 20 characters");

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

            /* RuleFor(p => p.Phone)
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
                 .WithMessage("Phone number can be null");*/
        }
    }
}