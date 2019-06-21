using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebNTMobileApp.Data.Entities;
using static WebNTMobileApp.Data.EF.Extensions.ModelBuilderExtebsions;

namespace WebNTMobileApp.Data.EF.Configurations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasMaxLength(50).IsUnicode(false);
            // etc.
        }
    }
}
