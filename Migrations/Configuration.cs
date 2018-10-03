namespace ASPNetMVCWithRoles.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ASPNetMVCWithRoles.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AppServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Suppliers.AddOrUpdate(x => x.Id,
                new Supplier()
                { Name = "Solar Inc.", Address = "ADB Pasig", Email = "inquiry@solar.com", IsActive = true },
                new Supplier()
                { Name = "Drugs Inc.", Address = "Shaw Mandaluyong", Email = "inquiry@drugs.com", IsActive = true },
                new Supplier()
                { Name = "Aso Inc.", Address = "Ayala Makati", Email = "inquiry@dogs.com", IsActive = true }
                );
        }
    }
}
