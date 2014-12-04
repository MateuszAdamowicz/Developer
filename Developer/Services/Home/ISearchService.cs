using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface ISearchService
    {
        ParsedSearch ParseKey(string key);
    }
}