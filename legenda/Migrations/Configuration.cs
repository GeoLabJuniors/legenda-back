namespace legenda.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using legenda.Models;
    using legenda.Models.Entities;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<legenda.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(legenda.Models.ApplicationDbContext context)
        {
            context.StaticData.AddOrUpdate(
                p=>p.KeyWord,
                new StaticData { KeyWord = "About", Value ="About"},
                new StaticData { KeyWord = "BrochurePath", Value="Brochure"},
                new StaticData { KeyWord = "Competition", Value="Competition"},
                new StaticData { KeyWord = "Contact", Value="Contact"}
                );

            context.Roles.AddOrUpdate(
                p=>p.Name,
                new IdentityRole { Name="Admin" },
                new IdentityRole { Name="Jury"  },
                new IdentityRole { Name="Moderator" },
                new IdentityRole { Name="User" }
                );

            context.SaveChanges();
        }
    }
}
