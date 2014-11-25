using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Developer.Models.ViewModels
{
    public class AdminWorker
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneFirst { get; set; }
        public string PhoneSecond { get; set; }
        [Required]
        public string Email { get; set; }
        public string OldPhoto { get; set; }
        public HttpPostedFileBase Photo { get; set; }
    }
}