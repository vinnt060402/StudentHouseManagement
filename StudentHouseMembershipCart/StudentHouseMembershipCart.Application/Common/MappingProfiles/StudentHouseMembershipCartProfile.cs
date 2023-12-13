using AutoMapper;
using StudentHouseMembershipCart.Application.Features.Apartments;
using StudentHouseMembershipCart.Application.Features.AttendenceReports;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries;
using StudentHouseMembershipCart.Application.Features.BookingDetails.Queries.GetBookingDetailDoNotAssignedBefore;
using StudentHouseMembershipCart.Application.Features.Bookings;
using StudentHouseMembershipCart.Application.Features.Categories.Queries;
using StudentHouseMembershipCart.Application.Features.FeaturesPackage;
using StudentHouseMembershipCart.Application.Features.Feedbacks.Queries;
using StudentHouseMembershipCart.Application.Features.PackageServices;
using StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries;
using StudentHouseMembershipCart.Application.Features.PaymentMethods;
using StudentHouseMembershipCart.Application.Features.PaymentNew.Dto;
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

            CreateMap<Domain.Entities.Service, ServiceData>().ReverseMap();
            CreateMap<ServiceData, Domain.Entities.Service>().ReverseMap();

            CreateMap<Category, CategoryData>().ReverseMap();
            CreateMap<CategoryData, Category>().ReverseMap();

            CreateMap<Package, PackageData>().ReverseMap();
            CreateMap<PackageData, Package>().ReverseMap();

            CreateMap<PackageService, PackageServiceData>().ReverseMap();
            CreateMap<PackageServiceData, PackageService>().ReverseMap();

            CreateMap<Booking, BookingData>().ReverseMap();
            CreateMap<BookingData, Booking>().ReverseMap();
            CreateMap<Booking, BookingDataNew>().ReverseMap();
            CreateMap<BookingDataNew, Booking>().ReverseMap();

            CreateMap<AttendReport, AttendReportData>().ReverseMap();
            CreateMap<AttendReportData, AttendReport>().ReverseMap();

            CreateMap<StudentData, Student>().ReverseMap();
            CreateMap<Student, StudentData>().ReverseMap();

            CreateMap<ApartmentData, Apartment>().ReverseMap();
            CreateMap<Apartment, ApartmentData>().ReverseMap();

            CreateMap<ApplicationStudent, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationStudent>().ReverseMap();
/*
            CreateMap<BookingDetailData, BookingDetail>().ReverseMap();
            CreateMap<BookingDetail, BookingDetailData>().ReverseMap();

            CreateMap<BookingDetailDoNotAssignedBeforeData, BookingDetail>().ReverseMap();
            CreateMap<BookingDetail, BookingDetailDoNotAssignedBeforeData>().ReverseMap();*/

            CreateMap<FeedBack, FeedBackData>().ReverseMap();
            CreateMap<FeedBackData, FeedBack>().ReverseMap();

            CreateMap<PaymentNew, PaymentDto>().ReverseMap();
            CreateMap<PaymentDto, PaymentNew>().ReverseMap();
        }
    }
}
