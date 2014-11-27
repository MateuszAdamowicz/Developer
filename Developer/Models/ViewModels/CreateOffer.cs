using System;
using System.ComponentModel.DataAnnotations;
using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class CreateOffer
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public AdType AdType { get; set; }
    }
}