using AutoMapper;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Common.MappingProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
