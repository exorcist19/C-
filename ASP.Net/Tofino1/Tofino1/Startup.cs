using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tofino1.Startup))]
namespace Tofino1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
