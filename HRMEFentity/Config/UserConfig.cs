using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;
using System.Data.Entity.ModelConfiguration;
namespace HRMEFentity.Config
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            this.ToTable(nameof(User));
            this.Property(e => e.u_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.u_true_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.u_password).HasMaxLength(60).IsRequired();
        }
    }
}
