using Microsoft.EntityFrameworkCore;
using ShopOnline.Data.EF.Extensions;
using ShopOnline.Data.Entities;

namespace ShopOnline.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}