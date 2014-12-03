using System.ComponentModel.DataAnnotations;

namespace Developer.Models.EntityModels
{
    public enum AdType
    
    {
        [Display(Name = "Mieszkanie")]
        Flat = 12,
        [Display(Name = "Dom")]
        House = 13,
        [Display(Name = "Działka")]
        Land = 14
    }
}