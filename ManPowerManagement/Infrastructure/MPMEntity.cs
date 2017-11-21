using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManPowerManagement.Models;

namespace ManPowerManagement.Infrastructure
{
    public class MPMEntity: DbContext
    {
        public MPMEntity():base("name=MPPConnection")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<SoldierPersonalInfo> SoldierPersonalInfos { get; set; }
        public DbSet<SoldierOfficialInfo> SoldierOfficialInfos { get; set; }
    }
}
