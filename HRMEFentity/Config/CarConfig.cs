using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;
using System.Data.Entity.ModelConfiguration;
namespace HRMEFentity.Config
{
    public class CarConfig : EntityTypeConfiguration<Car>
    {
        public CarConfig()
        {
            this.ToTable(nameof(Car));
            this.Property(e => e.CName).HasMaxLength(20).IsRequired();
        }
    }
}
