using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.Services.Commands.UpdateService
{
    public class UpdateServiceCommand : IRequest<SHMResponse>
    {
        public string ServiceId { get; set; } = null!;
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
        public string? Quantity { get; set; }
        public string? ImageURL { get; set; }
        public string? CategoryId { get; set; }
        public string? UpdateBy { get; set; }
    }
}
