using Developer.Models.EntityModels.Interfaces;

namespace Developer.Models.EntityModels
{
    public class Land: Ad, ILand
    {
        public string Area { get; set; }
        public string Ownership { get; set; }
    }
}