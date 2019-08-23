using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using HRMEFentity.Entity;
namespace HRMEFentity.MyContext
{
    public class TestContext : DbContext
    {
        public TestContext()
            : base("name=CommInfo")
        {
            Database.SetInitializer<TestContext>(null);//禁止建库操作
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        //public DbSet<Car> Cares { set; get; }
        //public DbSet<User> Useres { set; get; }
        //public DbSet<config_public_char> config_public_char { set; get; }
        //public DbSet<config_major_kind> config_major_kind { set; get; }
        public DbSet<config_major> config_major { set; get; }    //职位设置表

    }
}
 