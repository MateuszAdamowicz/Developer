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
                FirstName = "Miko�aj",
                LastName = "Koren",
                Email = "mkoren@pgs-soft.com",
            };

            var flat3 = new Flat()
            {
                City = "Jelenie G�ra",
                Location = "Zaborze III",
                Area = "62 m2",
                Storey = "IV pi�tro",
                TechnicalCondition = "do zamieszkania",
                Rooms = "3 pokoje",
                Heating = "sieciowe",
                Rent = "500z�",
                Ownership = "sp�dzielcze w� z KW",
                Price = "199 000z�",
                Description =
                    "Prezentuj� Pa�stwu do sprzeda�y trzypokojowe mieszkanie na osiedlu Zabobrze w jego nowszej cz�ci w ocieplonym bloku czteropi�trowym. Lokal zadbany, s�oneczny z balkonu rozpo�ciera si� �adny widok na panoram� pog�rza. Sprzeda� wraz z meblami i sprz�tem AGD.",
                Details =
                    "Op�aty zawarte w czynszu : inne , administracyjne , fundusz remontowy , ogrzewanie , woda ciep�a , Dodatkowe powierzchnie : Piwnica , Po�rednik odpowiedzialny : 4917 , NOTA PRAWNA : : Wszystkie szczeg�y ofert zestawiono na podstawie wypowiedzi lub dokumentacji przedstawionej przez w�a�cicieli nieruchomo�ci. Jednocze�nie nie bierzemy odpowiedzialno�ci za ich prawid�owo��, kompletno�� i aktualno��. Oferty nie stanowi� oferty handlowej w rozumieniu kodeksu cywilnego i nie s� wi���ce.",
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
                City = "Wroc�aw",
                Heating = "Piec"
            };

            var land1 = new Land()
            {
                City = "Szczecin",
                Area = "100"
            };
            var land2 = new Land()
            {
                City = "Wroc�aw",
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
