using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class WorkersViewModel
    {
        public IEnumerable<Worker> Workers { get; set; }
        public Response Response { get; set; }
    }
}