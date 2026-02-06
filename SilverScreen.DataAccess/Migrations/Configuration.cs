namespace SilverScreen.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SilverScreen.DataAccess.SilverScreenContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SilverScreen.DataAccess.SilverScreenContext";
        }

        protected override void Seed(SilverScreen.DataAccess.SilverScreenContext context)
        {
            new DatabaseSeeder(context).Seed();
        }
    }
}
