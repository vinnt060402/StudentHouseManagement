using AutoMapper;
using MediatR;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Queries.GetStudentAccountEmailPassword
{
    public class GetStudent_ByEmailPasswordQuery : IRequest<StudentDto>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
    public class GetStudent_ByEmailPasswordQueryHandler : IRequestHandler<GetStudent_ByEmailPasswordQuery, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetStudent_ByEmailPasswordQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<StudentDto> Handle(GetStudent_ByEmailPasswordQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetUserByEmailAndPassword(request.Email, request.Password);
            var result = _mapper.Map<StudentDto>(student);
            return result;
        }
    }
}
