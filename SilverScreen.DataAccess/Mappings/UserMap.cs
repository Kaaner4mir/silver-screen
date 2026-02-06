using SilverScreen.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverScreen.DataAccess.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("Users");
            this.HasKey(u => u.Id);

            this.Property(u => u.Username).IsRequired().HasMaxLength(50);
            this.Property(u => u.Password).IsRequired().HasMaxLength(100);
            this.Property(u => u.FullName).HasMaxLength(100);
            this.Property(u => u.Role).IsRequired().HasMaxLength(20);
        }
    }
}
