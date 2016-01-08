using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kraskarf.Mobile.Startup))]
namespace Kraskarf.Mobile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
