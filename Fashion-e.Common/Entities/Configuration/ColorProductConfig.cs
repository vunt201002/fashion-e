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
    public class ColorProductConfig : IEntityTypeConfiguration<ColorProduct>
    {
        public void Configure(EntityTypeBuilder<ColorProduct> builder)
        {
            builder.HasKey(c => c.Id);                              // khóa chính

            builder.Property(c => c.Name).HasMaxLength(150);        // tên màu

            builder.Property(c => c.ColorCode).HasMaxLength(20);    // mã màu

            builder.Property(c => c.Code).HasMaxLength(20);         // mã màu sản phẩm
        }
    }
}
