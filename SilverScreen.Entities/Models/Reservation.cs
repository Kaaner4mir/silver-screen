using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.Entities.Models
{
    public  class Reservation
    {
        public int Id { get; set; }
        public int ShowtimeId { get; set; }
        public int CustomerId { get; set; }
        public int SeatId { get; set; }
        public DateTime ReservationTime { get; set; }
        public bool IsPaid { get; set; }

        public virtual Showtime Showtime { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
