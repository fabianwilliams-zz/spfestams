using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(spt103vsbackend.Startup))]

namespace spt103vsbackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}