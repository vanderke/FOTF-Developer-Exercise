using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReadyToWed.Web.Configuration
{
    public sealed class Configuration
    {

        private Configuration()
        {
        }

        public static void Configure(Data.IModelReader reader)
        {
            ReadyToWed.Data.ModelReaderManager.Current = reader;
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        
    }
}