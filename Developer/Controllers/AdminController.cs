using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;
using Developer.Services.Admin;

namespace Developer.Controllers
{
    public class AdminController : Controller
    {
        private readonly IApplicationContext _applicationContext;

        // GET: Admin
        public AdminController(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewData["Workers"]= _applicationContext.Workers.ToList();
            return View(new AdminAdvertToAdd()
            {
                Workers = _applicationContext.Workers.ToList()
            });
        }

        [HttpPost]
        public ActionResult AddFlat(AdminFlat adminFlat)
        {
            if (ModelState.IsValid)
            {
                var serwis = new AddAdvertService(_applicationContext);
                var result = serwis.AddFlat(adminFlat);

            }

            return RedirectToAction("Add");
        }

        public ActionResult AddHouse(AdminHouse adminHouse)
        {
            throw new NotImplementedException();
        }

        public ActionResult AddLand(AdminLand adminLand)
        {
            throw new NotImplementedException();
        }
    }
}