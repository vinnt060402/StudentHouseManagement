using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.CreateApartment
{
    public class CreateApartmentCommandHandler : IRequestHandler<CreateApartmentCommand, Guid>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public CreateApartmentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Guid> Handle(CreateApartmentCommand request, CancellationToken cancellationToken)
        {
            // address la so nha, so tang, quan, phuong . Fe Validate cho User chọn theo thứ tự, chứu ko đc nhập tùy thích
            var addressOfApartmentExist = await _context.Apartment.Where(a => a.Address == request.AddressOfApartment).FirstOrDefaultAsync();
            if (addressOfApartmentExist != null)
            {
                throw new NotFoundException("The student has already registered for this apartment.");
            }
            var entity = new Apartment
            {
                Address = request.AddressOfApartment,
                StudentId = request.StudentId,
                RegionId = request.RegionId,
            };

            _context.Apartment.Add(entity);
            try
            {
                await _context.SaveChangesAsync();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return entity.Id;
        }
    }
}