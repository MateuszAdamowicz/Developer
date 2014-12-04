using Developer.Models;
using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface IEmailSenderService
    {
        Result SendOfferQuestion(ContactEmail contactEmail);
        Result SendContactQuestion(ContactEmail contactEmail);
        string GetOfferTemplate();
        string GetContactTemplate();
    }
}