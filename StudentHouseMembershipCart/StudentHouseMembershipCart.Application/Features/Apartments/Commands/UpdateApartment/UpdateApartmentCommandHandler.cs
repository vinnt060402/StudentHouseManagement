using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.UpdateApartment
{
    public class UpdateApartmentCommandHandler : IRequestHandler<UpdateApartmentCommand, Unit>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public UpdateApartmentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(UpdateApartmentCommand request, CancellationToken cancellationToken)
        {
            var apartmentIdExist = await _context.Apartment
                .Include(s => s.Student)
                .Include(s => s.Region)
                .FirstOrDefaultAsync(s => s.Id == request.ApartmentId);
            if (apartmentIdExist == null)
            {
                throw new NotFoundException("Apartment does not exist !");
            }


            if (apartmentIdExist.Student != null && apartmentIdExist.Region != null)
            {
                apartmentIdExist.Student.ApplicationUser.FullName = request.FullName;
                apartmentIdExist.Student.Phone = request.Phone;
                apartmentIdExist.Student.Birthday = request.Birthday;
                apartmentIdExist.Student.Address = request.AddressOfStudent;

                apartmentIdExist.Region.RegionName = request.RegionName;
            }
            apartmentIdExist.Address = request.AddressOfApartment;

            _context.Apartment.Update(apartmentIdExist);
            await _context.SaveChangesAsync();

            var user = await _userManager.FindByIdAsync(apartmentIdExist.Student.ApplicationUser.Id);
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