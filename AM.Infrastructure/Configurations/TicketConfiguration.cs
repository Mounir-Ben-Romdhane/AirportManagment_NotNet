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
    public class TicketConfiguration: IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            //cle primaire (passangerFK, flightFK, numTicket)
            builder.HasKey(t => new { t.PassengerFK, t.FlightFK, t.NumTicket });
            //one to many with passanger
            builder.HasOne(t => t.Passenger).WithMany(p => p.Tickets).HasForeignKey(t => t.PassengerFK);
            //one to many with flight
            builder.HasOne(t => t.Flight).WithMany(f => f.Tickets).HasForeignKey(t => t.FlightFK);
        }
    }
}
