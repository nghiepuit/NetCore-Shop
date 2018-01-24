using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnline.Data.EF.Extensions;
using ShopOnline.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline.Data.EF.Configurations
{
    class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(c => c.Id)
                .HasMaxLength(128)
                .IsRequired();
        }
    }
}
