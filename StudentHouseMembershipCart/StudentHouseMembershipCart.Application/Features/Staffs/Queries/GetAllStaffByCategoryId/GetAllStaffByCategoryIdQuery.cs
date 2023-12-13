using MediatR;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Queries.GetAllStaffByCategoryId
{
    public class GetAllStaffByCategoryIdQuery : IRequest<List<StaffResponse>>
    {
        public string ServiceId { get; set; }
    }
}