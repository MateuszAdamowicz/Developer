using System.Collections.Generic;
using Developer.Models.ViewModels;

namespace Developer.Models.EntityModels
{
    public class Statistics: Base
    {
        public virtual List<Session> Sessions { get; set; }
        public virtual List<Visit> Visits { get; set; }
    }
}