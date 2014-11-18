using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Developer.Models.ViewModels;

namespace Developer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new AdminAdvertToAdd());
        }

        [HttpPost]
        public ActionResult Add(AdminAdvertToAdd adminAdvertToAdd)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View(adminAdvertToAdd);
            }
        }
    }
}