using System.ComponentModel.DataAnnotations;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class AdminFlat
    {
        public string Location { get; set; }
        public string Area { get; set; }
        public string Storey { get; set; }
        public string TechnicalCondition { get; set; }
        public string Rooms { get; set; }
        public string Heating { get; set; }
        public string Rent { get; set; }
        public string Ownership { get; set; }
        public string PricePerMeter { get; set; }
        public bool ToLet { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Details { get; set; }
        public string City { get; set; }
        public string Price { get; set; }
        public int Worker { get; set; }
    }
}