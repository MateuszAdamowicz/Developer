using Microsoft.Practices.Unity;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Developer.Services.Admin;
using Unity.WebApi;

namespace Developer
{
    public class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationContext, ApplicationContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IAddAdvertService, AddAdvertService>();
        }
    }
}