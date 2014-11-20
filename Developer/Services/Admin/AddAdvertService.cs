using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;

namespace Developer.Services.Admin
{
    public class AddAdvertService : IAddAdvertService
    {
        private readonly IApplicationContext _context;
        private readonly IPhotoService _photoService;

        public AddAdvertService(IApplicationContext context, IPhotoService photoService)
        {
            _context = context;
            _photoService = photoService;
        }

        public Result AddFlat(AdminFlat adminFlat)
        {
            var flat = Mapper.Map<Flat>(adminFlat);
            var worker = Enumerable.First(_context.Workers.Where(x => x.Id == adminFlat.Worker));

            flat.Worker = worker;
            flat.Pictures = _photoService.AddAdvertPhotos(adminFlat.Files);
            foreach (var photo in flat.Pictures)
            {
                photo.AdType = AdType.Flat;
            }

            var result = _context.Flats.Add(flat);

            _context.SaveChanges();

            return new Result(true,null,"");
        }

        public Result AddLand(AdminLand adminLand)
        {
            var land = Mapper.Map<Land>(adminLand);
            var worker = Enumerable.First(_context.Workers.Where(x => x.Id == adminLand.Worker));

            land.Worker = worker;
            land.Pictures = _photoService.AddAdvertPhotos(adminLand.Files);
            foreach (var photo in land.Pictures)
            {
                photo.AdType = AdType.Land;
            }

            var result = _context.Lands.Add(land);

            _context.SaveChanges();

            return new Result(true, null, "");
        }

        public Result AddHouse(AdminHouse adminHouse)
        {
            var house = Mapper.Map<House>(adminHouse);
            var worker = Enumerable.First(_context.Workers.Where(x => x.Id == adminHouse.Worker));

            house.Worker = worker;
            house.Pictures = _photoService.AddAdvertPhotos(adminHouse.Files);
            foreach (var photo in house.Pictures)
            {
                photo.AdType = AdType.House;
            }

            var result = _context.Houses.Add(house);

            _context.SaveChanges();

            _context.SaveChanges();

            return new Result(true, null, "");
        }
    }
}