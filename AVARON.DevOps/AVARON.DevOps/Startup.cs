using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AVARON.DevOps.Startup))]
namespace AVARON.DevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
