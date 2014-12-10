using System.Collections.Generic;
using Developer.Models.ViewModels;

namespace Developer.Services.Home
{
    public interface INewestAdvertService
    {
        IEnumerable<NewestAdvert> GetNewest(int count);
    }
}