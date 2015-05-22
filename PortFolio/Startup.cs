using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortFolio.Startup))]
namespace PortFolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
