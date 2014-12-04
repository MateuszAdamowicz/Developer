using Developer.Models.ApplicationModels;

namespace Developer.Services.Home
{
    public interface ISmtpManager
    {
        void SendEmail(EmailMessage msg);
    }
}