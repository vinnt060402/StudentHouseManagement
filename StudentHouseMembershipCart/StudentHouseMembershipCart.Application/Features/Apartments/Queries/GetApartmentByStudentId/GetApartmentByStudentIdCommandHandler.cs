using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Application.Common.Exceptions;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment;
using StudentHouseMembershipCart.Application.Features.Students;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetApartmentByStudentId
{
    public class GetApartmentByStudentIdCommandHandler : IRequestHandler<GetApartmentByStudentIdCommand, List<ApartmentResponse>>
    {
        private IApplicationDbContext _dbContext;
        private IMapper _mapper;

        public GetApartmentByStudentIdCommandHandler(IApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ApartmentResponse>> Handle(GetApartmentByStudentIdCommand request, CancellationToken cancellationToken)
        {

            var apartments = await _dbContext.Apartment.Where(s => !s.IsDelete && s.StudentId == request.StudentId)
                                .Join(
                                    _dbContext.Student,
                                    apartment => apartment.StudentId,
                                    student => student.Id,
                                    (apartment, student) => new
                                    {
                                        Apartment = apartment,
                                        Student = student
                                    }
                                )
                                .Join(
                                    _dbContext.Region,
                                    combined => combined.Apartment.RegionId,
                                    region => region.Id,
                                    (combined, region) => new ApartmentResponse
                                    {
                                        Id = combined.Apartment.Id,
                                        Address = combined.Apartment.Address,
                                        RegionId = combined.Apartment.RegionId,
                                        StudentId = combined.Apartment.StudentId,
                                        InforStudentData = combined.Student,
                                        InforRegionData = region,
                                    }
                                )
                                .ToListAsync();
            if (!apartments.Any())
            {
                throw new NotFoundException(nameof(StudentDto), request.StudentId);
            }
            return apartments;
        }
    }
}