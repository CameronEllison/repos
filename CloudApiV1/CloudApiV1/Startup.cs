using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CloudApiV1.Startup))]

namespace CloudApiV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}