using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.EntityModels.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Models.EntityModels.ApplicationContext context)
        {

            var worker1 = new Worker()
            {
                FirstName = "Mateusz",
                LastName = "Adamowicz",
                Email = "madamowicz@pgs-soft.com",
                PhoneFirst = "794669564",
                PhoneSecond = "65465466"
            };

            var worker2 = new Worker()
            {
                FirstName = "Miko³aj",
                LastName = "Koren",
                Email = "mkoren@pgs-soft.com",
            };

            var flat3 = new Flat()
            {
                City = "Jelenie Góra",
                Location = "Zaborze III",
                Area = "62 m2",
                Storey = "IV piêtro",
                TechnicalCondition = "do zamieszkania",
                Rooms = "3 pokoje",
                Heating = "sieciowe",
                Rent = "500z³",
                Ownership = "spó³dzielcze w³ z KW",
                Price = "199 000z³",
                Description =
                    "Prezentujê Pañstwu do sprzeda¿y trzypokojowe mieszkanie na osiedlu Zabobrze w jego nowszej czêœci w ocieplonym bloku czteropiêtrowym. Lokal zadbany, s³oneczny z balkonu rozpoœciera siê ³adny widok na panoramê pogórza. Sprzeda¿ wraz z meblami i sprzêtem AGD.",
                Details =
                    "Op³aty zawarte w czynszu : inne , administracyjne , fundusz remontowy , ogrzewanie , woda ciep³a , Dodatkowe powierzchnie : Piwnica , Poœrednik odpowiedzialny : 4917 , NOTA PRAWNA : : Wszystkie szczegó³y ofert zestawiono na podstawie wypowiedzi lub dokumentacji przedstawionej przez w³aœcicieli nieruchomoœci. Jednoczeœnie nie bierzemy odpowiedzialnoœci za ich prawid³owoœæ, kompletnoœæ i aktualnoœæ. Oferty nie stanowi¹ oferty handlowej w rozumieniu kodeksu cywilnego i nie s¹ wi¹¿¹ce.",
                Title = "Trzypokojowe przy Kiepury",
                Pictures = new List<Photo>()
            };




            var house1 = new House()
            {
                City = "Szczecin",
                Heating = "Gazowe"
            };
            var house2 = new House()
            {
                City = "Wroc³aw",
                Heating = "Piec"
            };

            var land1 = new Land()
            {
                City = "Szczecin",
                Area = "100"
            };
            var land2 = new Land()
            {
                City = "Wroc³aw",
                Area = "110"
            };

            context.Workers.AddOrUpdate(p => p.LastName, worker1);
            context.Workers.AddOrUpdate(p => p.LastName, worker2);
            flat3.Worker = worker1;
            for (int i = 0; i < 13; i++)
            {
                flat3.Pictures.Add(new Photo()
                {
                    AdType = AdType.Flat,
                    Link = "728803_1.jpg"
                });
            }
            context.Flats.AddOrUpdate(p => p.Title, flat3);
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
