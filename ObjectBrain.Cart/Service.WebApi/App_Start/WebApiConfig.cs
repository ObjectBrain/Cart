using System.Web.Http;
using Service.WebApi.Ioc;

namespace Service.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new UnityResolver(UnityConfig.GetConfiguredContainer());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("CartApi", "api/{controller}/{id}", new {id = RouteParameter.Optional}
                );
        }
    }
}