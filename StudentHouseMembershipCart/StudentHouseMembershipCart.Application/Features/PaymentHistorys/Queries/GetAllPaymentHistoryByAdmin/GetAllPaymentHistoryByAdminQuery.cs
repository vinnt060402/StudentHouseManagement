using MediatR;

namespace StudentHouseMembershipCart.Application.Features.PaymentHistorys.Queries.GetAllPaymentHistoryByAdmin
{
    public class GetAllPaymentHistoryByAdminQuery : IRequest<List<PaymentHistoryData>>
    {
    }
}
