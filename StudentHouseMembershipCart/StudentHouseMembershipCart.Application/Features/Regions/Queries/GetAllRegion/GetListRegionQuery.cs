using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHouseMembershipCart.Application.Features.Regions.Queries.GetAllRegion
{
    public class GetListRegionQuery : IRequest<List<RegionDto>>
    {
    }
}