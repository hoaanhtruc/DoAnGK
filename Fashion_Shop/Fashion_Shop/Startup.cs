using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fashion_Shop.Startup))]
namespace Fashion_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
