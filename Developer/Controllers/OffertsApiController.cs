using Developer.Models.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.ViewModels;

namespace Developer.Controllers
{
    public class OffertsApiController : ApiController
    {
        private readonly IApplicationContext _context;

        public OffertsApiController(IApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<ShowListHouse> GetHouses()
        {
            List<House> houseData = _context.Houses.Where(x => x.Visible).ToList();//To change for true when implemented
            List<ShowListHouse> listHouse = AutoMapper.Mapper.Map<List<ShowListHouse>>(houseData);
            return listHouse;
        }

        public IEnumerable<ShowListFlat> GetFlats()
        {
            List<Flat> flatData = _context.Flats.Where(x => x.Visible).ToList(); //To change for true whe implemented
            List<ShowListFlat> listFlat= AutoMapper.Mapper.Map<List<ShowListFlat>>(flatData);
            return listFlat;
        }

        public IEnumerable<ShowListLand> GetLands()
        {
            List<Land> landData = _context.Lands.Where(x => x.Visible).ToList();//To change for true when implemented
            List<ShowListLand> listLand = AutoMapper.Mapper.Map<List<ShowListLand>>(landData);
            return listLand;
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
