using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;

namespace Developer.App_Start
{
    public class MapperConfig
    {
        public static void Register()
        {
            Mapper.CreateMap<Flat, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue("Mieszkanie"));
            Mapper.CreateMap<House, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue("Dom"));
            Mapper.CreateMap<Land, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue("Działka"));
        }
    }
}