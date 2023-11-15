using FluentValidation;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.UpdateStaff
{
    public class UpdateStaffCommandValidator : AbstractValidator<UpdateStaffCommand>
    {
        public UpdateStaffCommandValidator()
        {
            RuleFor(p => p.FullName)
                .NotEmpty().WithMessage("{FullName} is required")
                .NotNull()
                .MaximumLength(20).WithMessage("{FullName} must be fewer than 20 characters");
            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage("Phone number is required")
                .NotNull()
                .Matches(@"^\d{10}$")
                .WithMessage("Invalid phone number");
            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("Address is required")
                .NotNull()
                .MaximumLength(100).WithMessage("Address must be fewer than 100 chrarcters");
        }
    }
}