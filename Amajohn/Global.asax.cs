using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Amajohn.ViewModels;
using Amajohn.Infrastructure.Binders;

namespace Amajohn
{
    //public class Global : HttpApplication
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Add custom model binder
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}