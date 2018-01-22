﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopOnline.Data.EF.Extensions;
using ShopOnline.Data.Entities;

namespace ShopOnline.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
        }
    }
}