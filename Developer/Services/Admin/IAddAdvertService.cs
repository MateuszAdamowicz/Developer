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
        Result AddFlat(AdminFlat adminFlat);
        Result AddLand(AdminLand adminLand);
        Result AddHouse(AdminHouse adminHouse);
    }
}