using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Application.Contracts.Persistance
{
    public interface IPaymentMethodRepository : IGenericRepository<PaymentHistory>
    {

    }
}
