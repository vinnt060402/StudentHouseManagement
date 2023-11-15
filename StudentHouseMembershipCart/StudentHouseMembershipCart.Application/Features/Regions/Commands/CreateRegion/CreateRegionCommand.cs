using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Regions.Commands.CreateRegion
{
    public class CreateRegionCommand : IRequest<Guid>
    {
        public string RegionName { get; set; }
    }
}