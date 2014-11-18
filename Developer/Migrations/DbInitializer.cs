using System.Data.Entity;
using Developer.Models.EntityModels;

namespace Developer.Migrations
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var worker1 = new Worker()
            {
                FirstName = "Mateusz",
                LastName = "Adamowicz",
                Email = "madamowicz@pgs-soft.com",
                PhoneNumbers = new[] {"794669564"}
            };

            var worker2 = new Worker()
            {
                FirstName = "Mikołaj",
                LastName = "Koren",
                Email = "mkoren@pgs-soft.com",
                PhoneNumbers = new[] {"123123332"}
            };

            context.Workers.Add(worker1);
            context.Workers.Add(worker2);
            context.SaveChanges();
        }
    }
}