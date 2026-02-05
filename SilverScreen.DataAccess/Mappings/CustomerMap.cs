using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customers");

            HasKey(c => c.Id);

            Property(c => c.Name).IsRequired().HasMaxLength(50);

            Property(c => c.Surname).IsRequired().HasMaxLength(50);

            Property(c => c.PhoneNumber).HasMaxLength(50);

            Property(c => c.Email).HasMaxLength(50);

            HasMany(c => c.Reservations).WithRequired(r => r.Customer).HasForeignKey(r => r.CustomerId).WillCascadeOnDelete(false);
        }
    }
}
