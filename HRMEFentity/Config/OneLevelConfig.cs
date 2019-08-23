using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;
using System.Data.Entity.ModelConfiguration;
namespace HRMEFentity.Config
{
   public class OneLevelConfig: EntityTypeConfiguration<OneLevel>
    {
        public OneLevelConfig()
        {
            this.Property(e => e.first_kind_id).HasMaxLength(13);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
        }
    }
}
