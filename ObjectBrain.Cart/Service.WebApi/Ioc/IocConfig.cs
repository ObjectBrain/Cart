using System.Data.Entity;
using Data.Context;
using Data.Repository;
using Domain.Model;
using Microsoft.Practices.Unity;

namespace Service.WebApi.Ioc
{
    public class UnityConfig
    {
        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();
            var dbContext = new CartContext();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>),
                new ContainerControlledLifetimeManager(),
                new InjectionConstructor(
                    new InjectionParameter(typeof(DbContext), dbContext)
                    ));
            container.RegisterType<ICustomerService, CustomerService>();
            return container;
        }
    }
}
