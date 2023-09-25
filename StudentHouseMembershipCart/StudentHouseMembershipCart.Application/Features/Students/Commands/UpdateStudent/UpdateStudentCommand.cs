using AutoMapper;
using MediatR;
using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string NewStudentName { get; set; }
        public string NewPassword { get; set; }
        public string NewEmail { get; set; }
        public DateTime NewBirthday { get; set; }
        public string NewPhone { get; set; }
        public string NewAddress { get; set; }

        public Guid NewRoleId { get; set; }
        
        public Guid NewFeedbackId { get; set; }
    }

    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentCommandHandler(IMapper mapper, IStudentRepository studentRepository)
        {
            this._mapper = mapper;
            this._studentRepository = studentRepository;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var student = await _studentRepository.GetByIdAsync(request.Id);

            if (student == null) {
                throw new Exception("User not found");
            }
            student.StudentName = request.NewStudentName;
            student.Password = request.NewPassword;
            student.Email = request.NewEmail;
            student.Birthday = request.NewBirthday;
            student.Address = request.NewAddress;
            student.RoleId = 1;
            // convert to domain entity object
            var studentUpdate = _mapper.Map<Student>(student);

            // add database
            await _studentRepository.UpdateAsync(studentUpdate);


            // return
            return Unit.Value;
        }
    }
}
