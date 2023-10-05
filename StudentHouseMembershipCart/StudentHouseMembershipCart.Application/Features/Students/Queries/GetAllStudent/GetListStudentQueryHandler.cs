/*using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetAllStudent
{
    public class GetListStudentQueryHandler : IRequestHandler<GetListStudentQuery, List<Student>>
    {
        private IApplicationDbContext _context { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public GetListStudentQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager, IStudentRepository studentRepository)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
        {
            *//*var students = await _studentRepository.GetAsync();
            if (students == null || students.Count() == 0) {
                throw new NotFoundException(nameof(Student));
            }

            var map = _mapper.Map<List<StudentDto>>(students);*//*

            var list = await _context.Student.Where(e => e.IsDelete == false)
                .ProjectTo<StudentDto>(_mapper.ConfigurationProvider).ToListAsync();

            return;
        }
    }
}
*/