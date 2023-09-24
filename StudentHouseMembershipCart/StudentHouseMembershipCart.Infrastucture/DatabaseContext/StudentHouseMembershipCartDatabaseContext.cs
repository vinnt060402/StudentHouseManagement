using Microsoft.EntityFrameworkCore;
using StudentHouseMembershipCart.Domain.Common;

namespace StudentHouseMembershipCart.Infrastucture.DatabaseContext
{
    public class StudentHouseMembershipCartDatabaseContext : DbContext
    {
        public StudentHouseMembershipCartDatabaseContext(DbContextOptions<StudentHouseMembershipCartDatabaseContext> options) : base(options)
        {
        }

        public StudentHouseMembershipCartDatabaseContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(StudentHouseMembershipCartDatabaseContext).Assembly);
            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseAuditableEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.LastModified = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
