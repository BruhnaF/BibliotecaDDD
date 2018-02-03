using BibliotecaDDD.Infra.CrossCutting.IoC;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace BibliotecaDDD.Presentation.WebApi.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void InicializarInjecao()
        {
            var container = new Container();
            IoCModulo.Inicializador(ref container);

            GlobalConfiguration.Configuration.DependencyResolver 
                = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}