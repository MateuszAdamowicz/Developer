﻿using System;
using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class ShowListHouse
    {
        public string UsableArea { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Rent { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Rooms { get; set; }
        public virtual Photo Picture { get; set; }
    }
}