using System;

namespace Developer.Models.EntityModels.Interfaces
{
    public interface IAd
    {
        string Title { get; set; }
        string Description { get; set; }
        string Details { get; set; }
        string City { get; set; }
        string Price { get; set; }
        Worker Worker { get; set; }
        int Id { get; set; }
        DateTime? CreatedAt { get; set; }
    }
}