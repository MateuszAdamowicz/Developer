using Microsoft.Practices.Unity;
using System.Web.Http;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Unity.WebApi;

namespace Developer
{
    public class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationContext, ApplicationContext>(new HierarchicalLifetimeManager());
        }
    }
}