using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class CashRegisterMap:EntityTypeConfiguration<CashRegister>
    {
        public CashRegisterMap()
        {
            ToTable("Cash Register");

            HasKey(c=>c.Id);

            Property(c => c.Amount).HasColumnName("money").IsRequired();

            Property(c => c.Description).HasMaxLength(200);

            Property(c => c.TransactionDate).HasColumnName("datetime").IsRequired();
        }
    }
}
