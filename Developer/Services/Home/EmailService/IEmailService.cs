using Developer.Models;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;
using Developer.Models.ViewModels;

namespace Developer.Services.Home
{
    public interface IEmailService
    {
        Result SendAndSaveOfferQuestion(ContactEmail contactEmail);
        Result SendAndSaveContactQuestion(ContactEmail contactEmail);
        Result SendAndSaveOfferResponse(OfferStatus offerStatus, Offer offer);
    }
}