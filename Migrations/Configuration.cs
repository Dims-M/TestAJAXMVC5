namespace TestAJAXMVC5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RegistrationApplication.Models.Data.DBCont>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RegistrationApplication.Models.Data.DBCont";
        }

        protected override void Seed(RegistrationApplication.Models.Data.DBCont context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
