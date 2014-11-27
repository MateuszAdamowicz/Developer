using System.ComponentModel.DataAnnotations;
using Developer.Models.EntityModels;

namespace Developer.Models
{
    public class ContactEmail
    {
        [Required]
        public string FullName { get; set; }
        
        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        [Required]
        public string Body { get; set; }
        
        public string OfferLink { get; set; }
    }
}