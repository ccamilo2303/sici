using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SICI.Startup))]
namespace SICI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
