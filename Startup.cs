using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindEducators.Startup))]
namespace FindEducators
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
