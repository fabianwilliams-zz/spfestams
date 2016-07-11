using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(spt103portalService.Startup))]

namespace spt103portalService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}