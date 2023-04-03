using System.Web.Http;
using System.Web.Http.SelfHost;

namespace KarimiApp.Server.Api
{
   public class MyApiConfig
    {
        public static void RegisterHost(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            //config.MaxBufferSize = 250000000;
            //config.MaxReceivedMessageSize = 250000000;
        }
        public static void RegisterSelfHost(HttpSelfHostConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            //config.MaxBufferSize = 250000000;
            //config.MaxReceivedMessageSize = 250000000;
        }
    }
}
