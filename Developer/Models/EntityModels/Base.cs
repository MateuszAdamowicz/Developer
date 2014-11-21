using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Developer.Models.EntityModels.Interfaces;

namespace Developer.Models.EntityModels
{
    public class Base : IBase
    {
        public Base()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}