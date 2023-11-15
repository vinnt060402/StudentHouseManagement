using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class GetListStaffQuery : IRequest<List<StaffResponse>>
    {
    }
}