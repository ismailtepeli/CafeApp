using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CafeApp.Startup))]
namespace CafeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
