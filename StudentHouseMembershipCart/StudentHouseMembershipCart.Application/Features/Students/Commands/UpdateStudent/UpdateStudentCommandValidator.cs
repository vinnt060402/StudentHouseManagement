using FluentValidation;
using StudentHouseMembershipCart.Application.Common.Interfaces;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateStudentCommandValidator()
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