using StudentHouseMembershipCart.Application.Contracts.Persistance;
using StudentHouseMembershipCart.Domain.Entities;
using StudentHouseMembershipCart.Identity.DbContext;

namespace StudentHouseMembershipCart.Identity.Repositories
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(StudentHouseMembershipCartDatabaseContext context) : base(context)
        {
        }
    }
}
