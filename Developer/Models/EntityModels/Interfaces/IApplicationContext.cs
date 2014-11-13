﻿using System.Data.Entity;

namespace Developer.Models.EntityModels.Interfaces
{
    public interface IApplicationContext
    {
        IDbSet<Worker> Workers { get; set; }
        IDbSet<Flat> Flats { get; set; }
        IDbSet<House> Houses { get; set; }
        IDbSet<Land> Lands { get; set; }
        new void SaveChanges();
    }
}