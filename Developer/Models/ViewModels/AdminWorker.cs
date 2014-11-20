using System.Web;

namespace Developer.Models.ViewModels
{
    public class AdminWorker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneFirst { get; set; }
        public string PhoneSecond { get; set; }
        public string Email { get; set; }
        public string OldPhoto { get; set; }
        public HttpPostedFileBase Photo { get; set; }
    }
}