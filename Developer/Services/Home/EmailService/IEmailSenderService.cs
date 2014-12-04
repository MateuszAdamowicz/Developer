using Developer.Models;
using Developer.Models.ApplicationModels;
using Developer.Models.ViewModels;

namespace Developer.Services.Home
{
    public interface IEmailSenderService
    {
        Result SendOfferQuestion(ContactEmail contactEmail);
        Result SendContactQuestion(ContactEmail contactEmail);
        string GetOfferTemplate();
        string GetContactTemplate();
        Result SendOfferResponse(OfferStatus offerStatus, string destination);
        string GetOfferRejectedTemplate();
        string GetOfferAcceptedTemplate();
    }
}