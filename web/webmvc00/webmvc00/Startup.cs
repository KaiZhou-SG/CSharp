using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webmvc00.Startup))]
namespace webmvc00
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
