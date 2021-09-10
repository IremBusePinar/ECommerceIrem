namespace Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bogus;
    using Model.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Model.Context.AppDbContext context)
        {

            //Todo: fake data tanýmlanacak.
        }
    }
}
