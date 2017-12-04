namespace Cars.Data.Migrations
{
        using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cars.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cars.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Manufacturers.AddOrUpdate(item => item.id, new Manufacturer { Name = "���� ����", Country = "Usa" }, new Manufacturer { Name = "Pepsi ����", Country = "Usa" });
        }
    }
}
