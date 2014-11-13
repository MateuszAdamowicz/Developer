using Developer.Models.EntityModels.Interfaces;

namespace Developer.Models.EntityModels
{
    public class Worker: Base, IWorker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string Email { get; set; }
    }
}