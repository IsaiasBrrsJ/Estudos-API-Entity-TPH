using Cumpom.Core.Entities.Coupon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cupom.Infrastructure.Repositories.Configurations
{
    public class CouponConfiguration : IEntityTypeConfiguration<Couponn>
    {
        public void Configure(EntityTypeBuilder<Couponn> builder)
        {
            builder.ToTable(nameof(Couponn));


            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();


            builder
               .HasOne(x => x.Client)
               .WithMany(x => x.Coupons)
               .HasForeignKey(x => x.ClientId);


            builder
                .HasDiscriminator<CouponWithDiscount>("CouponWithDescount");

        }
    }
}
