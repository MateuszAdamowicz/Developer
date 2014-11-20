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
        Result<int> AddFlat(AdminFlat adminFlat);
        Result<int> AddLand(AdminLand adminLand);
        Result<int> AddHouse(AdminHouse adminHouse);
    }
}