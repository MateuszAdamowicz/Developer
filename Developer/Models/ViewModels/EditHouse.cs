using System.Collections.Generic;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class EditHouse: AdminHouse
    {
        public List<Photo> Pictures { get; set; }
        public List<int> ToDeleted { get; set; }
    }
}