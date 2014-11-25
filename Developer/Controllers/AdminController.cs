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
            if (!TempData.ContainsKey("AdType"))
            {
                TempData["AdType"] = 0;
            }
            ViewData["Workers"] = _applicationContext.Workers.ToList();
            return View(new AdminAdvertToAdd());
        }

        [HttpGet]
        public ActionResult AddFlat()
        {
            TempData["AdType"] = 0;
            return RedirectToAction("AddAdvert");
        }

        [HttpPost]
        public ActionResult AddFlat(AdminFlat adminFlat)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddFlat(adminFlat);
                return RedirectToAction("Show", "Home", new { id = result.Data, adType = AdType.Flat });
            }
            ViewData["Workers"] = _applicationContext.Workers.ToList();
            TempData["AdType"] = 0;
            return View("AddAdvert", new AdminAdvertToAdd() { Flat = adminFlat });
        }

        [HttpGet]
        public ActionResult AddHouse()
        {
            TempData["AdType"] = 1;
            return RedirectToAction("AddAdvert");
        }

        [HttpPost]
        public ActionResult AddHouse(AdminHouse adminHouse)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddHouse(adminHouse);
                return RedirectToAction("Show", "Home", new { id = result.Data, adType = AdType.House });
            }
            ViewData["Workers"] = _applicationContext.Workers.ToList();
            TempData["AdType"] = 1;
            return View("AddAdvert", new AdminAdvertToAdd() { House = adminHouse });
        }

        [HttpGet]
        public ActionResult AddLand()
        {
            TempData["AdType"] = 2;
            return RedirectToAction("AddAdvert");
        }
        [HttpPost]
        public ActionResult AddLand(AdminLand adminLand)
        {
            if (ModelState.IsValid)
            {
                var result = _addAdvertService.AddLand(adminLand);
            }
            ViewData["Workers"] = _applicationContext.Workers.ToList();
            TempData["AdType"] = 2;
            return View("AddAdvert", new AdminAdvertToAdd() { Land = adminLand });
        }

        public ActionResult Workers()
        {
            var workers = _applicationContext.Workers.ToList();
            var workersVm = new WorkersViewModel() { Workers = workers };
            return View(workersVm);
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
                    var workers = _applicationContext.Workers.ToList();
                    var response = new Response()
                    {
                        Message = "Dodano nowego pracownika!",
                        Success = true
                    };
                    var workersVm = new WorkersViewModel() {Workers = workers, Response = response};
                    return View("Workers", workersVm);
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
                    var workers = _applicationContext.Workers.ToList();
                    var response = new Response()
                    {
                        Message = "Pomyślnie edytowano pracownika!",
                        Success = true
                    };
                    var workersVm = new WorkersViewModel() {Workers = workers, Response = response};
                    return View("Workers", workersVm);
                }
                return View(adminWorker);
            }
            return View(adminWorker);
        }

        [HttpGet]
        public ActionResult Photos()
        {
            return View(_applicationContext.Photos.ToList());
        }
    }
}