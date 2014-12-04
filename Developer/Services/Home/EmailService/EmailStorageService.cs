using Developer.Models;
using Developer.Models.ApplicationModels;
using Developer.Models.EntityModels;

namespace Developer.Services.Home
{
    public class EmailStorageService : IEmailStorageService
    {
        private readonly ApplicationContext _applicationContext;

        public EmailStorageService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Result SaveEmail(ContactEmail contactEmail)
        {
            var mail = AutoMapper.Mapper.Map<Mail>(contactEmail);
            _applicationContext.Mails.Add(mail);
            _applicationContext.SaveChanges();

            return new Result(true, null ,"");
        }
    }
}