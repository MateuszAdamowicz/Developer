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

            var flat1= new Flat()
            {
                City = "Szczecin",
                Heating = "Gazowe"
            };
            var flat2 = new Flat()
            {
                City = "Wrocław",
                Heating = "Piec"
            };

            var house1 = new House()
            {
                City = "Szczecin",
                Heating = "Gazowe"
            };
            var house2 = new House()
            {
                City = "Wrocław",
                Heating = "Piec"
            };

            var land1 = new Land()
            {
                City="Szczecin",
                Area="100"
            };
            var land2 = new Land()
            {
                City = "Wrocław",
                Area = "110"
            };

            context.Workers.Add(worker1);
            context.Workers.Add(worker2);
            context.Houses.Add(house1);
            context.Houses.Add(house2);
            context.Flats.Add(flat1);
            context.Flats.Add(flat2);
            context.Lands.Add(land1);
            context.Lands.Add(land2);
            context.SaveChanges();
        }
    }
}