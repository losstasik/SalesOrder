namespace Sales.DataLayer.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sales.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Sales.DataLayer.SalesContext context)
        {

            context.SalesOrder.AddOrUpdate(
                  p => p.CustomerName,
                  new SalesOrder {CustomerName = "Adam", PONumber= "132465798" },
                  new SalesOrder { CustomerName = "Stan", PONumber = "842" },
                  new SalesOrder { CustomerName = "Mike", PONumber = "82121" },
                  new SalesOrder { CustomerName = "Kate", PONumber = "876548" }
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
