using AutoMapper;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.Regions;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Common.MappingProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();

            CreateMap<RegionDto, Region>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();

            CreateMap<ApartmentDto, Apartment>().ReverseMap();
            CreateMap<Apartment, ApartmentDto>().ReverseMap();
        }
    }
}
