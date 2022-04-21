using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityAuthentication.Startup))]
namespace SecurityAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
