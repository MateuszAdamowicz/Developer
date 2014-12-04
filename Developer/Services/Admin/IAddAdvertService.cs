using System;
using System.Collections.Generic;
using System.Web;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;
using Developer.Models.ViewModels;

namespace Developer.Services.Admin
{
    public interface IAddAdvertService
    {
        Result<string> AddFlat(AdminFlat adminFlat);
        Result<string> AddLand(AdminLand adminLand);
        Result<string> AddHouse(AdminHouse adminHouse);
    }
}