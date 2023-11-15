using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Staffs.Commands.DeleteStaff
{
    public class DeleteStaffCommand : IRequest<SHMResponse>
    {
        public Guid Id { get; set; }
        public string? DeleteBy { get; set; }
    }
}