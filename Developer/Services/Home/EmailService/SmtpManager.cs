using System.Configuration;
using System.Net.Mail;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;

namespace Developer.Services.Home
{
    public class SmtpManager : ISmtpManager
    {
        private readonly string _domainName;


        public SmtpManager()
        {
            _domainName = ConfigurationManager.AppSettings["emailDomain"];
        }

        public void SendEmail(EmailMessage msg)
        {
            var client = new SmtpClient();

            var mail = new MailMessage(_domainName, msg.Destination)
            {
                Subject = msg.Topic,
                Body = msg.Body,
                IsBodyHtml = true
            };

            client.Send(mail);
        }
    }
}