using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Entities.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseTime { get; set; }

        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
