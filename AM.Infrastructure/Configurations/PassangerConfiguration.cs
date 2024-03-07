using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PassangerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasDiscriminator<string>("IsTraveller")
                .HasValue<Passenger>("O")
                .HasValue<Traveller>("1")
                .HasValue<Staff>("2");

            builder.OwnsOne(p => p.fullName, fn =>
            {
                fn.Property(p => p.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                fn.Property(p => p.LastName).HasColumnName("PassLastName").IsRequired();
            });
        }
    }
}
