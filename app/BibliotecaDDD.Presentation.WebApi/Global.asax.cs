using BibliotecaDDD.Presentation.WebApi.App_Start;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace BibliotecaDDD.Presentation.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.UseXmlSerializer = true;
            SimpleInjectorConfig.InicializarInjecao();

        }
    }
}
