using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineReadyToWed.Startup))]
namespace OnlineReadyToWed
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
