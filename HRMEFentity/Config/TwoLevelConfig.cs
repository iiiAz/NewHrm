using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMEFentity.Entity;
using System.Data.Entity.ModelConfiguration;
namespace HRMEFentity.Config
{
   public class TwoLevelConfig:EntityTypeConfiguration<TwoLevel>
    {
        public TwoLevelConfig()
        {
            this.Property(e => e.first_kind_id).HasMaxLength(13);
            this.Property(e => e.first_kind_name).HasMaxLength(60);
            this.Property(e => e.second_kind_name).HasMaxLength(60);
            this.Property(e => e.second_salary_id).HasMaxLength(500);
            this.Property(e => e.second_kind_id).HasMaxLength(13);
            this.Property(e => e.second_sale_id).HasMaxLength(500);
        }
    }
}
