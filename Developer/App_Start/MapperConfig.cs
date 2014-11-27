using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using AutoMapper;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Models.ViewModels;
using RazorEngine.Configuration;

namespace Developer.App_Start
{
    public class MapperConfig
    {
        public static void Register()
        {
            Mapper.CreateMap<Flat, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue(AdType.Flat));
            Mapper.CreateMap<House, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue(AdType.House));
            Mapper.CreateMap<Land, AdminAdvertToShow>().ForMember(dest => dest.AdType, opts => opts.UseValue(AdType.Land));
            Mapper.CreateMap<AdminFlat, Flat>().ForMember(dest => dest.Worker, opts => opts.UseValue(null));
            Mapper.CreateMap<AdminLand, Land>().ForMember(dest => dest.Worker, opts => opts.UseValue(null));
            Mapper.CreateMap<AdminHouse, House>().ForMember(dest => dest.Worker, opts => opts.UseValue(null));
            Mapper.CreateMap<Worker, ShowWorker>().ForMember(dest => dest.Id, opts => opts.UseValue(0));
            Mapper.CreateMap<Flat, ShowFlat>().ForMember(dest => dest.Worker, opts => opts.MapFrom(src => Mapper.Map<ShowWorker>(src.Worker)));
            Mapper.CreateMap<House, ShowHouse>().ForMember(dest => dest.Worker, opts => opts.MapFrom(src => Mapper.Map<ShowWorker>(src.Worker)));
            Mapper.CreateMap<Land, ShowLand>().ForMember(dest => dest.Worker, opts => opts.MapFrom(src => Mapper.Map<ShowWorker>(src.Worker)));
            Mapper.CreateMap<AdminWorker, Worker>();
            Mapper.CreateMap<Worker, AdminWorker>()
                .ForMember(dest => dest.OldPhoto, opts => opts.MapFrom(src => src.HasPhoto ? src.Photo : String.Empty))
                .ForMember(dest => dest.Photo, opts => opts.UseValue(null));
            Mapper.CreateMap<Photo, ShowListPhoto>();
            Mapper.CreateMap<Flat, ShowListFlat>()
                .ForMember(dest => dest.Picture, opts => opts.MapFrom(src => Mapper.Map<ShowListPhoto>(src.Pictures.FirstOrDefault())));
            Mapper.CreateMap<House, ShowListHouse>()
                .ForMember(dest => dest.Picture, opts => opts.MapFrom(src => Mapper.Map<ShowListPhoto>(src.Pictures.FirstOrDefault())));
            Mapper.CreateMap<Land, ShowListLand>()
                .ForMember(dest => dest.Picture, opts => opts.MapFrom(src => Mapper.Map<ShowListPhoto>(src.Pictures.FirstOrDefault())));

            Mapper.CreateMap<Flat, EditFlat>().ForMember(dest => dest.Worker, opts => opts.MapFrom(src => src.Worker.Id));
            Mapper.CreateMap<House, EditHouse>()
                .ForMember(dest => dest.Worker, opts => opts.MapFrom(src => src.Worker.Id));

        }
    }
}