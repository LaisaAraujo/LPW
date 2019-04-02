using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FJI_Corp.Startup))]
namespace FJI_Corp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
