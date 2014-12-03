using Microsoft.Practices.Unity;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Services.Admin;
using Developer.Services.Home;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using Unity.WebApi;

namespace Developer
{
    public class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationContext, ApplicationContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IAddAdvertService, AddAdvertService>();
            container.RegisterType<IPhotoService, PhotoService>();
            container.RegisterType<IWorkerService, WorkerService>();
            container.RegisterType<ITemplateService, TemplateService>();
            container.RegisterType<IEmailService, EmailService>();
            container.RegisterType<ITemplateServiceConfiguration, TemplateServiceConfiguration>();
            container.RegisterType<IUpdateAdvertService, UpdateAdvertService>();
            container.RegisterType<ISearchService, SearchService>();
            container.RegisterType<ISmtpManager, SmtpManager>();
            container.RegisterType<IEmailSenderService, EmailSenderService>();
            container.RegisterType<IEmailStorageService, EmailStorageService>();
            container.RegisterType<IShowAdvertService, ShowAdvertService>();

        }
    }
}