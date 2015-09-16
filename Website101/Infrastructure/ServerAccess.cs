using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website101.Infrastructure {
  public static class ServerAccess {

    private static HttpServerUtility _server;

    public static void SetServer( HttpServerUtility server ) {
      ServerAccess._server = server;
    }

    public static HttpServerUtility Server {
      get {
        return ServerAccess._server;
      }
    }
  }
}