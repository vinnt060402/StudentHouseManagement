using MediatR;
using StudentHouseMembershipCart.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Apartments.Commands.UpdateApartment
{
    public class UpdateApartmentCommand : IRequest<Unit>
    {
        public Guid ApartmentId { get; set; }

        public string AddressOfApartment { get; set; }
        //student
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string AddressOfStudent { get; set; }
        //region
        public string RegionName { get; set; }


        
    }
}
