﻿using AutoMapper;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.Bookings;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage;
using StudentHouseMembershipCart.Application.Features.PackageServices;
using StudentHouseMembershipCart.Application.Features.Regions;
using StudentHouseMembershipCart.Application.Features.Services;
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

            CreateMap<Service, ServiceData>().ReverseMap();
            CreateMap<ServiceData, Service>().ReverseMap();

            CreateMap<Category, CategoryData>().ReverseMap();
            CreateMap<CategoryData, Category>().ReverseMap();

            CreateMap<Package, PackageData>().ReverseMap();
            CreateMap<PackageData, Package>().ReverseMap();

            CreateMap<PackageService, PackageServiceData>().ReverseMap();
            CreateMap<PackageServiceData, PackageService>().ReverseMap();

            CreateMap<Booking, BookingData>().ReverseMap();
            CreateMap<BookingData, Booking>().ReverseMap();
        }
    }
}
