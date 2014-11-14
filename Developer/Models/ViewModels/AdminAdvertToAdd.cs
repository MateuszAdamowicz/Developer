using System;
using System.Collections;
using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class AdminAdvertToAdd
    {
        public AdminAdvertToAdd()
        {
            Flat = new AdminFlat();
            Land = new AdminLand();
            House = new AdminHouse();
        }

        public AdminFlat Flat { get; set; }
        public AdminLand Land { get; set; }
        public AdminHouse House { get; set; }
        public IEnumerable<Worker> Workers { get; set; }
    }
}