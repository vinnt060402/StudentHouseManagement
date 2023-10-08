using AutoMapper;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.Regions;
using StudentHouseMembershipCart.Application.Features.Staffs.Queries;
using StudentHouseMembershipCart.Application.Features.Students;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Domain.IdentityModels;

namespace StudentHouseMembershipCart.Application.Common.MappingProfiles
{
    public class StudentHouseMembershipCartProfile : Profile
    {
        public StudentHouseMembershipCartProfile()
        {
            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();

            CreateMap<RegionDto, Region>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();

            CreateMap<ApartmentDto, Apartment>().ReverseMap();
            CreateMap<Apartment, ApartmentDto>().ReverseMap();

            CreateMap<Staff, StaffResponse>().ReverseMap();
            CreateMap<StaffResponse, Staff>().ReverseMap();

            CreateMap<StaffData, Staff>().ReverseMap();
            CreateMap<Staff, StaffData>().ReverseMap();

            CreateMap<ApplicationStaff, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationStaff>();
        }
    }
}
