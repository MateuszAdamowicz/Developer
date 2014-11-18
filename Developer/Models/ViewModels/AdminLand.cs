using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class AdminLand
    {
        public string Location { get; set; } // 
        public string Area { get; set; } // 
        public string Ownership { get; set; } // 
        public string Title { get; set; } // 
        public string Description { get; set; } //
        public string Details { get; set; } //
        public string City { get; set; } // 
        public string Price { get; set; } // 
        public Worker Worker { get; set; }
    }
}