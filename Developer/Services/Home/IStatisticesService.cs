using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface IStatisticesService
    {
        Result AddDailyUser(string session);
        Result AddDailyView(string number);
    }
}