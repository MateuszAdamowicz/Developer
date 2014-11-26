using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class AdminLand
    {
        public string Location { get; set; } // 
        public string Area { get; set; } // 
        public string Ownership { get; set; } // 
        [Required]
        public string Title { get; set; } // 
        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } //
        [DataType(DataType.MultilineText)]
        public string Details { get; set; } //
        [Required]
        public string City { get; set; } // 
        [Required]
        public string Price { get; set; } // 
        public int Worker { get; set; }
        public IEnumerable<HttpPostedFileBase> Files { get; set; }
    }
}