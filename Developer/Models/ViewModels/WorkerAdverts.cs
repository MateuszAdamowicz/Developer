using System.Collections;
using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class WorkerAdverts: Worker
    {
        public IEnumerable<NewestAdvert> Adverts { get; set; }
    }
}