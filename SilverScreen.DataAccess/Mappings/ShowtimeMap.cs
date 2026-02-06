using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class ShowtimeMap : EntityTypeConfiguration<Showtime>
    {
        public ShowtimeMap()
        {
            this.ToTable("Showtimes");
            this.HasKey(s => s.Id);

            this.Property(s => s.HallName).IsRequired().HasMaxLength(50);
            this.Property(s => s.StartTime).IsRequired();
            this.Property(s => s.Price).HasPrecision(18, 2);

            this.HasRequired(s => s.Movie)
                .WithMany(m => m.Showtimes)
                .HasForeignKey(s => s.MovieId);
        }
    }
}
