using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REST.Site.Startup))]
namespace REST.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
