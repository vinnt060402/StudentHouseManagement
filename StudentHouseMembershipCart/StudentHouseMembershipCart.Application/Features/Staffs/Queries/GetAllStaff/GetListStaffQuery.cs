using MediatR;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class GetListStaffQuery : IRequest<List<StaffResponse>>
    {
    }
}
