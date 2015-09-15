using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace ReadyToWed.WebSite
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            ReadyToWed.Web.Configuration.Configuration.Configure(
                                                                    new Data.FileModelReader(
                                                                                                new IO.WebFileReader(Server.MapPath("~/App_Data")),
                                                                                                new Serialization.JsonDeserializer(),
                                                                                                ".json"
                                                                                            )
                                                                 );
        }
    }
}