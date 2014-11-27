using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Developer.Models;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;
using Developer.Services.Home;

namespace Developer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationContext _context;
        private readonly IEmailService _emailService;
        // GET: Home
        public HomeController(IApplicationContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public ActionResult SendEmail(ContactEmail contactEmail)
        {
            if (ModelState.IsValid)
            {
                var result = _emailService.SendQuestion(contactEmail);
            }
            

            return View("Index");
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

        public ActionResult CreateOffer()
        {
            return View(new CreateOffer());
        }

        [HttpPost]
        public ActionResult CreateOffer(CreateOffer createOffer)
        {
            if (ModelState.IsValid)
            {
                var offer = AutoMapper.Mapper.Map<Offer>(createOffer);
                _context.Offers.Add(offer);
                _context.SaveChanges();
                return View(new CreateOffer());
            }
            return View(createOffer);
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}