using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Benavides.WEB.Startup))]
namespace Benavides.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
