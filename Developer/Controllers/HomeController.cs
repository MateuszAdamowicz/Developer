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

        public ActionResult Show(int id)
        {
            var flat = Enumerable.First(_context.Flats.Where(x => x.Id == id));
            var showFlat = AutoMapper.Mapper.Map<ShowFlat>(flat);
            return View(showFlat);
        }
    }
}