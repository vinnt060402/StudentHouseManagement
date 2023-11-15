using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetStaff
{
    public class GetStaffQuery : IRequest<StaffResponse>
    {
        public Guid Id { get; set; }
    }
}