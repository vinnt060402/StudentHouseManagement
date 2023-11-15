using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentByStudentId
{
    public class GetStudentByStudentIdCommandHandler : IRequestHandler<GetStudentByStudentIdCommand, StudentDataNew>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetStudentByStudentIdCommandHandler(UserManager<ApplicationUser> userManager, IApplicationDbContext dbContext, IMapper mapper)
        {
            _userManager = userManager;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<StudentDataNew> Handle(GetStudentByStudentIdCommand request, CancellationToken cancellationToken)
        {
            var student = await _dbContext.Student.Where(x => x.Id == request.StudentId).SingleOrDefaultAsync();
            if (student == null)
            {
                throw new NotFoundException(nameof(StudentDto), request.StudentId);
            }
            var applicationUser = await _userManager.FindByIdAsync(student.ApplicationUserId);

            if (applicationUser == null)
            {
                throw new NotFoundException(nameof(StudentDto), request.StudentId);
            }

            var apartment = await _dbContext.Apartment.Where(x => x.StudentId == request.StudentId).ToListAsync();

            var studentData = _mapper.Map<StudentData>(student);
            var applicationData = _mapper.Map<ApplicationStudent>(applicationUser);
            List<ApartmentData> data = new List<ApartmentData>();
            if (apartment.Any())
            {
                foreach (var item in apartment)
                {
                    var ap = _mapper.Map<ApartmentData>(item);
                    data.Add(ap);
                }
            }
            else
            {
                data = null;
            }
            return new StudentDataNew
            {
                ApartmentData = data,
                ApplicationUserData = applicationData,
                StudentData = studentData
            };
        }
    }
}