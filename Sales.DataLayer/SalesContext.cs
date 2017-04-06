using Sales.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.DataLayer
{
    public class SalesContext : DbContext
    {

        public SalesContext() : base("SalesDbCollection")
        {

        }


        public DbSet<SalesOrder> SalesOrder { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
        }

    }
}
