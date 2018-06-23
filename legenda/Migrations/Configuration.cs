namespace legenda.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using legenda.Models;
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
            context.Contents.AddOrUpdate(
                p=>p.Name,
                new Content { Name = "About", Value ="About"},
                new Content { Name="BrochurePath", Value="Brochure"},
                new Content { Name="Competition", Value="Competition"},
                new Content { Name="Contact", Value="Contact"}
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
