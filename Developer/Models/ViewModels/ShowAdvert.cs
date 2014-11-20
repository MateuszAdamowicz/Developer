using Developer.Models.EntityModels;

namespace Developer.Models.ViewModels
{
    public class ShowAdvert
    {
        public AdType AdType { get; set; }
        public ShowHouse House { get; set; }
        public ShowFlat Flat { get; set; }
        public ShowLand Land { get; set; }
    }
}