﻿using System;
using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class ShowListLand
    {
        public string Area { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public virtual Photo Picture { get; set; }
    }
}