using AutoMapper;
using MediatR;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.CreateStudent
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IMapper mapper, IStudentRepository studentRepository)
        {
            this._mapper = mapper;
            this._studentRepository = studentRepository;
        }

        public async Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data

            // convert domain entity object
            var studentCreate = _mapper.Map<Student>(request);

            // add to database
            await _studentRepository.CreateAsync(studentCreate);

            // return record id
            return studentCreate.Id;
        }
    }
}
