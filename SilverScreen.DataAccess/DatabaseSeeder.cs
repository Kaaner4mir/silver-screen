using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess
{
    public class DatabaseSeeder
    {
        private readonly SilverScreenContext _context;

        public DatabaseSeeder(SilverScreenContext context)
        {
            _context = context;
        }

        public void SeedSeat()
        {
            if(!_context.Seats.Any())
            {
               for (int i = 1; i <= 100; i++)
                {
                    _context.Seats.Add(new Entities.Models.Seat
                    {
                        HallName = "Hall 1",
                        SequenceNumber = (i - 1) / 10 + 1, 
                        SeatNumber =i,
                        Taken = false
                    });
                }
                _context.SaveChanges();
            }
        }
    }
}
