using Cumpom.Core.Entities.Client.Coupon;
using Cumpom.Core.Entities.Coupon;
using Cupom.Infrastructure.Repositories.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Cupom.Infrastructure.Repositories
{
    public class DbContextCp : DbContext
    {
        public DbContextCp(DbContextOptions<DbContextCp> options) : base(options)
        {
        }
    
        public DbSet<Couponn> Coupons { get; set; }
        public DbSet<Clientt> Clientt { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CouponConfiguration).Assembly);
        }

    }
}
