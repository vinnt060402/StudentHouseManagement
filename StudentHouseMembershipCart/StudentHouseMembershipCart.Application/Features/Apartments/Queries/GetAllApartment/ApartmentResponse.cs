using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Queries.GetAllApartment
{
    public class ApartmentResponse
    {
        public Student? InforStudentData { get; set; }
        public Region? InforRegionData { get; set; }
        public Apartment? InforApartmentData { get; set; }
    }
}
