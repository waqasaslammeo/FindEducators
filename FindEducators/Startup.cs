using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FindEducators.Startup))]
namespace FindEducators
{
    public partial class Startup
    {

        //sdfsfsdfsdfsdfsdfdsfs
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
