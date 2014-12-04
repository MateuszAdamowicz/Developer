using Developer.Models;
using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public class EmailService : IEmailService
    {
        private readonly IEmailSenderService _emailSenderService;
        private readonly IEmailStorageService _emailStorageService;

        public EmailService(IEmailSenderService emailSenderService, IEmailStorageService emailStorageService)
        {
            _emailSenderService = emailSenderService;
            _emailStorageService = emailStorageService;
        }

        public Result SendAndSaveOfferQuestion(ContactEmail contactEmail)
        {
            _emailSenderService.SendOfferQuestion(contactEmail);
            _emailStorageService.SaveEmail(contactEmail);
            
            return new Result(true, null , "");
        }

        public Result SendAndSaveContactQuestion(ContactEmail contactEmail)
        {
            _emailSenderService.SendContactQuestion(contactEmail);
            _emailStorageService.SaveEmail(contactEmail);
            
            return new Result(true, null, "");
        }
    }
}