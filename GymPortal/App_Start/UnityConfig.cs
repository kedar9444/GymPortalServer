using GymPortal.Data.Interfaces.Repository;
using GymPortal.Data.Interfaces.Services;
using GymPortal.Data.Repository;
using GymPortal.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace GymPortal
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRepository, UserRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}