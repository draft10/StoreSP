using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreSP.Startup))]
namespace StoreSP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
