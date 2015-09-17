using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website101.Infrastructure {
  public static class ServerAccess {

    private static HttpServerUtility _server;

    private static HttpServerUtility Server {
      get {
        if ( _server == null && HttpContext.Current != null ) {
          _server = HttpContext.Current.Server;
        }
        return _server;
      }
    }

    public static bool IsAccess {
      get {
        return Server != null;
      }
    }

    /// <summary>
    /// Map the given directory path.
    /// </summary>
    /// <param name="path">A partial path. (i.e. "~/dir/")</param>
    /// <returns>Full server path.</returns>
    public static string MapPath( string path ) {
      IPathProvider provider;
      if ( IsAccess ) {
        provider = new ServerPathProvider();
      }
      else {
        provider = new TestPathProvider();
      }
      return provider.MapPath( path );
    }
  }
}