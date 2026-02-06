using SilverScreen.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace SilverScreen.DataAccess.Mappings
{
    public class ReservationMap : EntityTypeConfiguration<Reservation>
    {
        public ReservationMap()
        {
            ToTable("Reservations");

            Property(r => r.Id);

            Property(r => r.ReservationTime).HasColumnType("datetime").IsRequired();

            this.HasRequired(r => r.Showtime)
                .WithMany(s => s.Reservations)
                .HasForeignKey(r => r.ShowtimeId)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(c => c.CustomerId)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Seat)
                .WithMany(s => s.Reservations)
                .HasForeignKey(r => r.SeatId)
                .WillCascadeOnDelete(false);
        }
    }
}