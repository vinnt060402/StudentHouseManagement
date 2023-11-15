using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.DeleteApartment
{
    public class DeleteApartmentCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }

    public class DeleteApartmentCommandHandler : IRequestHandler<DeleteApartmentCommand, Unit>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public DeleteApartmentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(DeleteApartmentCommand request, CancellationToken cancellationToken)
        {
            var apartmentIdExist = await _context.Apartment.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
            if (apartmentIdExist == null)
            {
                throw new NotFoundException(nameof(apartmentIdExist.Student.ApplicationUser.Email), request.Id);
            }
            else if (apartmentIdExist.IsDelete == true)
            {
                throw new NotFoundException("The apartment have been deleted");
            }

            apartmentIdExist.IsDelete = true;
            _context.Apartment.Update(apartmentIdExist);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}