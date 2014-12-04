using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;
using Developer.Models.ViewModels;

namespace Developer.Services.Home
{
    public interface IShowAdvertService
    {
        Result<ShowAdvert> GetAdvert(AdType adType, int id);
    }
}