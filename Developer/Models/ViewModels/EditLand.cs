using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class EditLand: AdminLand
    {
        public List<Photo> Pictures { get; set; }
        public List<int> ToDeleted { get; set; }
    }
}