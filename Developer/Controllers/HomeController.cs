using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;

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

            //var x = _context.Workers.ToArray();
            //var y = _context.Flats.ToArray();
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
    }
}