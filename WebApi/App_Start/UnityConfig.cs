using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Repositories;
using ServiceLayer;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IAutoMapper, AutoMapping>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IAdminRepository, AdminRepository>();
            container.RegisterType<IAdminService, AdminService>();
            container.RegisterType<IPatientRepository, PatientRepository>();
            container.RegisterType<IPatientService, PatientService>();

            container.RegisterType<ILogger, Log4net>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}