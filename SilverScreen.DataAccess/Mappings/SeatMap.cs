using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class SeatMap:EntityTypeConfiguration<Seat>
    {
        public SeatMap()
        {
            ToTable("Seats");

            HasKey(s => s.Id);

            Property(s => s.HallName).IsRequired().HasMaxLength(50);

            Property(s => s.SequenceNumber).IsRequired();

            Property(s=>s.SeatNumber).IsRequired();

            Property(s=>s.Taken).IsRequired();

            HasMany(s=>s.Reservations).WithRequired(r=>r.Seat).HasForeignKey(r=>r.SeatId).WillCascadeOnDelete(false);
        }
    }
}
