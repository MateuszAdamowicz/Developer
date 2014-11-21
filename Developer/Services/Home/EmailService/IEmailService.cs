using Developer.Models;
using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface IEmailService
    {
        Result SendQuestion(ContactEmail contactEmail);
        string GetTemplate();
    }
}