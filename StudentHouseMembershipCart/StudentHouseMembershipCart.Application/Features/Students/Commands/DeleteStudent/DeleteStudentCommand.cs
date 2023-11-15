using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }

    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public DeleteStudentCommandHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDelete = await _context.Student.Where(e => e.Id == request.Id).FirstOrDefaultAsync();
            if (studentDelete == null)
            {
                throw new NotFoundException(nameof(studentDelete.ApplicationUser.Email), request.Id);
            }
            else if (studentDelete.IsDelete == true)
            {
                throw new NotFoundException("The student have been deleted");
            }

            studentDelete.IsDelete = true;
            _context.Student.Update(studentDelete);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}