using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HRMEFentity.Entity;

namespace HRMEFentity.Config
{
   public class config_majorConfig:EntityTypeConfiguration<config_major>
    {
        public config_majorConfig()
        {
            this.ToTable(nameof(config_major));
            this.Property(e => e.major_id).HasMaxLength(2);
            this.Property(e => e.major_kind_name).HasMaxLength(60);
            this.Property(e => e.major_id).HasMaxLength(2);
            this.Property(e => e.major_name).HasMaxLength(60);

        }
    }
}
