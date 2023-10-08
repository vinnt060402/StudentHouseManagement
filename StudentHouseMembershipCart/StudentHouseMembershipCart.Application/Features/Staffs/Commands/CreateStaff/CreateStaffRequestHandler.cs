using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System.Transactions;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.CreateStaff
{
    public class CreateStaffRequestHandler : IRequestHandler<CreateStaffRequest, SHMResponse>
    {
        private IApplicationDbContext _dbContext { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public CreateStaffRequestHandler(IApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IMapper mapper)
        {
            _dbContext = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<SHMResponse> Handle(CreateStaffRequest request, CancellationToken cancellationToken)
        {
            var staffExist = _dbContext.Staff.Where(x => x.ApplicationUser.Email == request.Email || x.ApplicationUser.UserName == request.UserName || x.ApplicationUser.NormalizedEmail == request.Email).SingleOrDefault();
            if (staffExist != null)
            {
                throw new BadRequestException("The username or email already exists!");
            }
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var staff = new ApplicationUser
                {
                    Email = request.Email,
                    NormalizedEmail = request.Email.ToUpper(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = request.UserName,
                    NormalizedUserName = request.UserName.ToUpper(),
                    FullName = request.FullName,
                    PhoneNumber = request.Phone,
                    PhoneNumberConfirmed = true,
                    EmailConfirmed = true,
                };
                var result = await _userManager.CreateAsync(staff, request.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(staff, "Staff");
                    await _signInManager.SignInAsync(staff, isPersistent: false);
                }
                else
                {
                    throw new BadRequestException("Account creation failed !");
                }
                var newStaff = new Staff
                {
                    staffName = request.FullName,
                    ApplicationUserId = staff.Id,
                    Birthday = request.Birthday,
                    Address = request.Address,
                };
                await _dbContext.Staff.AddAsync(newStaff);
                await _dbContext.SaveChangesAsync();
                scope.Complete();
                return new SHMResponse
                {
                    Message = "Create succesfully!"
                };
            }
               
        }
    }
}
