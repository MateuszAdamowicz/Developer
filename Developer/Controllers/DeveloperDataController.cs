using Developer.Models.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Developer.Models.EntityModels;

namespace Developer.Controllers
{
    public class DeveloperDataController : ApiController
    {
        private readonly IApplicationContext _context;

        public DeveloperDataController(IApplicationContext context)
        {
            _context = context;
        }

        List<House> houseData = new List<House>()
        {
            new House{Id=1, City="Szczecin",Heating="Gazowe"},
            new House{Id=2, City="Wrocław",Heating="Piec"},
            new House{Id=3, City="Warszawa",Heating="Gazowe"},
            new House{Id=4, City="Kraków",Heating="Elektryczne"},
            new House{Id=5, City="Poznań",Heating="Gazowe"},
            new House{Id=6, City="Poznań",Heating="Gazowe"}
        };

        List<Flat> flatData = new List<Flat>()
        {
            new Flat{Id=1, City="Szczecin",Heating="Gazowe"},
            new Flat{Id=2, City="Wrocław",Heating="Piec"},
            new Flat{Id=3, City="Warszawa",Heating="Gazowe"},
            new Flat{Id=4, City="Kraków",Heating="Elektryczne"},
            new Flat{Id=5, City="Poznań",Heating="Gazowe"},
            new Flat{Id=6, City="Poznań",Heating="Gazowe"}
        };

        List<Land> landData = new List<Land>()
        {
            new Land{Id=1, City="Szczecin",Area="100"},
            new Land{Id=2, City="Wrocław",Area="123"},
            new Land{Id=3, City="Warszawa",Area="101"},
            new Land{Id=4, City="Kraków",Area="101"},
            new Land{Id=5, City="Poznań",Area="101"},
            new Land{Id=6, City="Poznań",Area="110"}
        };
        public IEnumerable<House> GetHouses()
        {
            return houseData;
        }

        public IEnumerable<Flat> GetFlats()
        {
            return flatData;
        }

        public IEnumerable<Land> GetLands()
        {
            return landData;
        }
        public House Put(House user)
        {
            //Update the user
            return user;
        }

        public House Post(House user)
        {
            return null;
        }

    }
}
