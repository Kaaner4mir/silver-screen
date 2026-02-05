using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            ToTable("Movies");

            HasKey(f => f.Id);

            Property(m => m.Name).IsRequired().HasMaxLength(50);
            Property(m => m.Type).IsRequired().HasMaxLength(50);
            Property(m => m.Type).IsRequired().HasMaxLength(50);
            Property(m => m.Duration).IsRequired();
            Property(m => m.ReleaseTime).IsRequired().HasColumnType("datetime");
            HasMany(m => m.Reservations).WithRequired(r => r.Movie).HasForeignKey(r => r.MovieId).WillCascadeOnDelete(false);
        }
    }
}
