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
    public class SizeColorProductConfig : IEntityTypeConfiguration<SizeColorProduct>
    {
        public void Configure(EntityTypeBuilder<SizeColorProduct> builder)
        {
            builder.HasKey(x => x.Id);                      // khóa chính

            builder.HasOne<Product>()
                .WithMany()
                .HasForeignKey(x => x.ProductId);           // khóa ngoại đến product

            builder.HasOne<SizeProduct>()
                .WithMany()
                .HasForeignKey(x => x.SizeProductId);       // khóa ngoại đến size

            builder.HasOne<ColorProduct>()
                .WithMany()
                .HasForeignKey(x => x.ColorProductId);      // khóa ngoại đến color
        }
    }
}
