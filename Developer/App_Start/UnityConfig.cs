using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Developer.Models.EntityModels;
using Developer.Models.EntityModels.Interfaces;
using Microsoft.Practices.Unity;

namespace Developer.App_Start
{
    public class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationContext, ApplicationContext>(new HierarchicalLifetimeManager());
        }
    }
}