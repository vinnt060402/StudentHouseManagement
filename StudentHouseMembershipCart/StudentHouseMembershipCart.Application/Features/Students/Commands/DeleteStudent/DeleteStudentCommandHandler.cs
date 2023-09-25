using AutoMapper;
using MediatR;
using StudentHouseMembershipCart.Application.Contracts.Persistance;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public DeleteStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper) 
        {
            this._studentRepository = studentRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            // retrieve domain entity object
            var studentDelete = await _studentRepository.GetByIdAsync(request.Id);

            // verify that record exists

            // rmove database
            await _studentRepository.DeleteAsync(studentDelete);

            // return
            return Unit.Value;
        }
    }
}
