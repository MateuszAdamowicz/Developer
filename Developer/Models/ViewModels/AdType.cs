using System.ComponentModel.DataAnnotations;

namespace Developer.Models.EntityModels
{
    public enum AdType
    
    {
        [Display(Name = "Mieszkanie")]
        Flat,
        [Display(Name = "Dom")]
        House,
        [Display(Name = "Działka")]
        Land
    }
}