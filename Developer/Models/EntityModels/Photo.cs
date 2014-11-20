using Developer.Models.EntityModels.Interfaces;

namespace Developer.Models.EntityModels
{
    public class Photo: Base
    {
        public string Link { get; set; }
        public AdType AdType { get; set; }
    }
}