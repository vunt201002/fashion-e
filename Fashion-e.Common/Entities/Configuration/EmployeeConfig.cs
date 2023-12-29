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
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);                          // khóa chính

            builder.Property(c => c.Name).HasMaxLength(20);
            builder.Property(c => c.Phone).HasMaxLength(15);
            builder.Property(c => c.Email).HasMaxLength(25);

            builder.Property(c => c.Address).HasMaxLength(150);
        }
    }
}
