using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class AdminAdvertToShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public bool Visible { get; set; }
        public Worker Worker { get; set; }
        public string AdType { get; set; }
    }
}