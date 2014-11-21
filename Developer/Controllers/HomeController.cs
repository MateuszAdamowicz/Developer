using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;

namespace Developer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationContext _context;
        // GET: Home
        public HomeController(IApplicationContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();        
        }
        public ActionResult House()
        {
            return View();
        }
        public ActionResult Flat()
        {
            return View();
        }
        public ActionResult Land()
        {
            return View();
        }

        public ActionResult Show(int id, AdType adType)
        {
            var showAdvert = new ShowAdvert {AdType = adType};

            if (adType == AdType.Flat)
            {
                var flat = Enumerable.FirstOrDefault(_context.Flats.Where(x => x.Id == id));
                if (flat == null)
                {
                    return RedirectToAction("NotFound");
                } 
                var showFlat = AutoMapper.Mapper.Map<ShowFlat>(flat);
                showAdvert.Flat = showFlat;
            }
            else if (adType == AdType.House)
            {
                var house = Enumerable.FirstOrDefault(_context.Houses.Where(x => x.Id == id));
                if (house == null)
                {
                    return RedirectToAction("NotFound");
                } 
                var showHouse = AutoMapper.Mapper.Map<ShowHouse>(house);
                showAdvert.House = showHouse;
            }
            else if (adType == AdType.Land)
            {
                var land = Enumerable.FirstOrDefault(_context.Lands.Where(x => x.Id == id));
                if (land == null)
                {
                    return RedirectToAction("NotFound");
                } 
                var showLand = AutoMapper.Mapper.Map<ShowLand>(land);
                showAdvert.Land = showLand;
            }

            return View(showAdvert);
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}