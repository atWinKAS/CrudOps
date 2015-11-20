using SimpleCrudOps.Models;

namespace SimpleCrudOps.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleCrudOps.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleCrudOps.Data.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Users.AddOrUpdate(
              p => p.Name,
              new User { Name = "Andrew Peters", Address = "DK"},
              new User { Name = "Brice Lambson", Address = "UA"},
              new User { Name = "Rowan Miller", Address = "GB", ContactNo = "123"}
            );

        }
    }
}
