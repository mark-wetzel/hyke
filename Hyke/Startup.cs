using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hyke.Startup))]
namespace Hyke
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
