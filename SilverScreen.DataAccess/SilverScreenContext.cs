using SilverScreen.DataAccess.Mappings;
using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess
{
    public class SilverScreenContext : DbContext
    {
        public SilverScreenContext():base("SilverScreenEFContext") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new CashRegisterMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
