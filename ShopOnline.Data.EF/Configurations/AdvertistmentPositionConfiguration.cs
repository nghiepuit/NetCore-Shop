using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnline.Data.EF.Extensions;
using ShopOnline.Data.Entities;

namespace ShopOnline.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}