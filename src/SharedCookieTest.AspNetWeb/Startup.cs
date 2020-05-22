using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharedCookieTest.AspNetWeb.Startup))]
namespace SharedCookieTest.AspNetWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
