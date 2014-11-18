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
    public class OffertsApiController : ApiController
    {
        private readonly IApplicationContext _context;

        public OffertsApiController(IApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<House> GetHouses()
        {
            List<House> houseData = _context.Houses.ToList();
            return houseData;
        }

        public IEnumerable<Flat> GetFlats()
        {
            List<Flat> flatData = _context.Flats.ToList();
            return flatData;
        }

        public IEnumerable<Land> GetLands()
        {
            List<Land> landData = _context.Lands.ToList();
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
