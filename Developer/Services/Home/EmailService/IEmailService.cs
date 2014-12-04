using Developer.Models;
using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface IEmailService
    {
        Result SendAndSaveOfferQuestion(ContactEmail contactEmail);
        Result SendAndSaveContactQuestion(ContactEmail contactEmail);
    }
}