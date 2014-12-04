using Developer.Models;
using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface IEmailStorageService
    {
        Result SaveEmail(ContactEmail contactEmail);
    }
}