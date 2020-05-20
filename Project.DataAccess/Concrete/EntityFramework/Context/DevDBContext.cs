using Project.DataAccess.Concrete.EntityFramework.Mapping;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Concrete.EntityFramework.Context
{
    public class DevDBContext : DbContext
    {
        public DevDBContext()
        {
            Database.SetInitializer<DevDBContext>(null);
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

        // Add DbSet here for more tables/entities to be added in the project. 
        // Create the corresponding mapping class(like ProductMap.cs) for the tables and add it in the above model builder.
    }
}
