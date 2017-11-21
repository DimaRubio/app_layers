using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Domain;
using BAL;

namespace app_layers
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
			container.RegisterType<IGetCategory, GetCategory>();
			container.RegisterType<IGetOrder, GetOrder>();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}