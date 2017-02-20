using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gastbok.Startup))]
namespace Gastbok
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
