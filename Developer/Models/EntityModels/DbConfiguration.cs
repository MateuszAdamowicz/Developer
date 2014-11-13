using System.Data.Entity.Migrations;

namespace Developer.Models.EntityModels
{
    public sealed class DbConfiguration: DbMigrationsConfiguration<ApplicationContext>
    {
        public DbConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}