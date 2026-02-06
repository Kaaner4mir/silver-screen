using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Entities.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public string HallName { get; set; }
        public int SequenceNumber { get; set; }
        public int SeatNumber { get; set; }
        public bool Taken { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
