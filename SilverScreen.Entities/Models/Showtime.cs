using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Entities.Models
{
    public class Showtime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string HallName { get; set; }
        public DateTime StartTime { get; set; }
        public decimal Price { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
