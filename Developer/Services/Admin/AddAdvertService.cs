using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;

namespace Developer.Services.Admin
{
    public class AddAdvertService
    {
        private readonly IApplicationContext _context;

        public AddAdvertService(IApplicationContext context)
        {
            _context = context;
        }

        public Result AddFlat(AdminFlat adminFlat)
        {
            var flat = Mapper.Map<Flat>(adminFlat);

            flat.Pictures = SavePictures(adminFlat.Files);

            var result = _context.Flats.Add(flat);

            _context.SaveChanges();

            return new Result(true,null,"");
        }

        public Result AddLand(AdminLand adminLand)
        {
            var land = Mapper.Map<Land>(adminLand);

            var result = _context.Lands.Add(land);

            _context.SaveChanges();

            return new Result(true, null, "");
        }

        public Result AddHouse(AdminHouse adminHouse)
        {
            var house = Mapper.Map<House>(adminHouse);

            var result = _context.Houses.Add(house);

            _context.SaveChanges();

            return new Result(true, null, "");
        }

        public IEnumerable<String> SavePictures(IEnumerable<HttpPostedFileBase> files)
        {
            var pictures = new List<String>();

            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.ContentLength > 0)
                    {
                        var fileName = String.Format("{0}_{1}", DateTime.Now.ToString("FFFFFFF"), file.FileName);
                        var path = HttpContext.Current.Server.MapPath("~/Content/Photos/");
                        file.SaveAs(path+fileName);
                        pictures.Add(fileName);
                    }
                }
            }

            return pictures;
        }
    }
}