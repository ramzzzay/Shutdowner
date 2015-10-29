using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoolShop.Startup))]
namespace CoolShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
