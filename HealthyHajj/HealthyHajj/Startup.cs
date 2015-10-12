using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyHajj.Startup))]
namespace HealthyHajj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
