using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fashion_e.Common.Entities.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);                          // khóa chính

            builder.Property(p => p.Title).HasMaxLength(50);
            builder.Property(p => p.Material).HasMaxLength(50);

            builder.HasOne<Category>()
                .WithMany()
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
