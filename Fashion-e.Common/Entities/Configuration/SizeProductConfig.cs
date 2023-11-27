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
    public class SizeProductConfig : IEntityTypeConfiguration<SizeProduct>
    {
        public void Configure(EntityTypeBuilder<SizeProduct> builder)
        {
            builder.HasKey(c => c.Id);                          // khóa chính

            builder.Property(c => c.Name).HasMaxLength(150);
        }
    }
}
