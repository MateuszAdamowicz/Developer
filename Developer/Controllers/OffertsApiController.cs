using Developer.Models.EntityModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.ViewModels;
using Developer.Services.Home;

namespace Developer.Controllers
{
    public class OffertsApiController : ApiController
    {
        private readonly IApplicationContext _context;
        private readonly INewestAdvertService _newestAdvertService;

        public OffertsApiController(IApplicationContext context, INewestAdvertService newestAdvertService)
        {
            _context = context;
            _newestAdvertService = newestAdvertService;
        }


        public IEnumerable<NewestAdvert> GetNewest()
        {
            return _newestAdvertService.GetNewest(4);
        }

        public IEnumerable<ShowListHouse> GetHouses()
        {
            List<House> houseData = _context.Houses.Where(x => x.Visible && !x.Deleted).ToList();
            List<ShowListHouse> listHouse = AutoMapper.Mapper.Map<List<ShowListHouse>>(houseData);
            return listHouse;
        }

        public IEnumerable<ShowListFlat> GetFlats()
        {
            List<Flat> flatData = _context.Flats.Where(x => x.Visible && !x.Deleted).ToList();
            List<ShowListFlat> listFlat= AutoMapper.Mapper.Map<List<ShowListFlat>>(flatData);
            return listFlat;
        }

        public IEnumerable<ShowListLand> GetLands()
        {
            List<Land> landData = _context.Lands.Where(x => x.Visible && !x.Deleted).ToList();
            List<ShowListLand> listLand = AutoMapper.Mapper.Map<List<ShowListLand>>(landData);
            return listLand;
        }

        public House Put(House user)
        {
            return user;
        }

        public House Post(House user)
        {
            return null;
        }

    }
}
