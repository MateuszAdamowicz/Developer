using System;

namespace Developer.Models.EntityModels.Interfaces
{
    public interface IBase
    {
        int Id { get; set; }
        DateTime? CreatedAt { get; set; }
    }
}