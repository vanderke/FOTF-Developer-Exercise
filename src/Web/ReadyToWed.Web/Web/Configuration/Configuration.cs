using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

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
            MvcConfiguration.Configure(RouteTable.Routes);
            BundleConfiguration.Configure(BundleTable.Bundles);
        }
        
    }
}