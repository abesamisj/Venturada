using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Venturada.UI.Startup))]
namespace Venturada.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
