namespace SkoolMgmt.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SkoolMgmt.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin",   },
                new IdentityRole { Name = "Teacher" },
                new IdentityRole { Name = "Student" }
            );
        }
    }
}
