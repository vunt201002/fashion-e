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
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Phone).HasMaxLength(15);
            builder.Property(x => x.Address).HasMaxLength(150);
            builder.Property(x => x.Note).HasMaxLength(200);
            builder.Property(x => x.Status).HasMaxLength(30);

            builder.HasOne<Shipper>()
                .WithMany()
                .HasForeignKey(x => x.ShipId);

            builder.HasOne<Customer>()
                .WithMany()
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(x =>x.ConfirmId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(x => x.PackagedId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(x => x.DeliverdId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
