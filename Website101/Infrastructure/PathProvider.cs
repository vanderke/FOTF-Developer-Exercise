using System.IO;
using System.Web;

namespace Website101.Infrastructure {

  interface IPathProvider {

    /// <summary>
    /// Map the given directory path.
    /// </summary>
    /// <param name="path">A partial path. (i.e. "~/dir/")</param>
    /// <returns>Full server path.</returns>
    string MapPath( string path );
  }

  public class ServerPathProvider : IPathProvider {

    /// <summary>
    /// Map the given directory path.
    /// </summary>
    /// <param name="path">A partial path. (i.e. "~/dir/")</param>
    /// <returns>Full server path.</returns>
    public string MapPath( string path ) {
      return HttpContext.Current.Server.MapPath( path );
    }
  }

  public class TestPathProvider : IPathProvider {

    /// <summary>
    /// Map the given directory path.
    /// </summary>
    /// <param name="path">A partial path. (i.e. "~/dir/")</param>
    /// <returns>Full server path.</returns>
    public string MapPath( string path ) {
      // Make sure this path matches the path to your project directory.
      string hardPath = @"C:\Projects\FOTF-Developer-Exercise\Website101\";
      if ( !Directory.Exists( hardPath ) ) {
        throw new DirectoryNotFoundException( "Invalid project directory path." );
      }
      return Path.Combine( hardPath, path.Trim( new char[] { '~', '/' } ) );
    }
  }
}
