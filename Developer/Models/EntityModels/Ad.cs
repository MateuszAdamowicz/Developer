namespace Developer.Models.EntityModels.Interfaces
{
    public class Ad: Base, IAd
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string City { get; set; }
        public string Price { get; set; }
        public Worker Worker { get; set; }
        public bool Visible { get; set; }
        public bool Deleted { get; set; }
    }
}