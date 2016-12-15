using System;
using System.Net.Http.Headers;
using Domain.Entity;
using Microsoft.Practices.Unity;
using Presentation.Wpf.Service;
using Presentation.Wpf.ViewModel;
using Service.WebApi.Client;

namespace Presentation.Wpf.Ioc
{
    public class UnityConfig
    {
        public static IUnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();

            var httpConfiguration = new HttpClientConfiguration(new Uri("http://localhost:18511/api/"),
                new MediaTypeWithQualityHeaderValue("application/json"));

            //container.RegisterInstance(typeof(IHttpClientConfiguration), httpConfiguration);

            container.RegisterType(
                typeof(ICartClientProxy<Customer>),
                typeof(CartClientProxy<Customer>), ServiceName.Customer.ToString(),
                new InjectionConstructor(
                    new InjectionParameter(typeof(IHttpClientConfiguration), httpConfiguration),
                    new InjectionParameter(typeof(ServiceName),
                    ServiceName.Customer)
                    ));

            container.RegisterType(typeof(ICartClientService<>), typeof(CartClientService<>));

            container.RegisterType<ICustomerViewModel, CustomerViewModel>(
                new InjectionConstructor(
                    new InjectionParameter(
                        typeof(ICartClientService<Customer>),
                        container.Resolve(
                            typeof(ICartClientService<Customer>)
                            , new DependencyOverride(
                                typeof(ICartClientProxy<Customer>),
                                container.Resolve(typeof(ICartClientProxy<Customer>),
                                ServiceName.Customer.ToString()))))));

            return container;
        }
    }
}