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
        private readonly IAddAdvertService _addAdvertService;
        private readonly IWorkerService _workerService;

        // GET: Admin
        public AdminController(IApplicationContext applicationContext, IAddAdvertService addAdvertService, IWorkerService workerService)
        {
            _applicationContext = applicationContext;
            _addAdvertService = addAdvertService;
            _workerService = workerService;
        }

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddAdvert()
        {
            ViewData["Workers"]= _applicationContext.Workers.ToList();
            return View(new AdminAdvertToAdd());
        }

        [HttpPost]
        public ActionResult AddFlat(AdminFlat adminFlat)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddFlat(adminFlat);

            }

            return RedirectToAction("AddAdvert");
        }

        [HttpPost]
        public ActionResult AddHouse(AdminHouse adminHouse)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddHouse(adminHouse);
            }
            return RedirectToAction("AddAdvert");
        }

        [HttpPost]
        public ActionResult AddLand(AdminLand adminLand)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddLand(adminLand);
            }
            return RedirectToAction("AddAdvert");
        }

        public ActionResult Workers()
        {
            return View(_applicationContext.Workers.ToList());
        }



        public ActionResult AddWorker()
        {
            return View(new AdminWorker());
        }

        [HttpPost]
        public ActionResult AddWorker(AdminWorker adminWorker)
        {
            if (ModelState.IsValid)
            {
                var result = _workerService.AddWorker(adminWorker);

                if (result.Success == true)
                {
                    return RedirectToAction("Workers");
                }
                return View(adminWorker);
            }
            return View(adminWorker);
        }

        public ActionResult EditWorker(int id)
        {
            var worker = Enumerable.FirstOrDefault(_applicationContext.Workers.Where(obj => obj.Id == id));

            var adminWorker = AutoMapper.Mapper.Map<AdminWorker>(worker);

            return View(adminWorker);
        }

        [HttpPost]
        public ActionResult EditWorker(AdminWorker adminWorker, int id)
        {
            if (ModelState.IsValid)
            {
                var result = _workerService.EditWorker(adminWorker, id);
                if (result.Success == true)
                {
                    return RedirectToAction("Workers");
                }
                return View(adminWorker);
            }
            return ViewBag(adminWorker);
        }
    }
}