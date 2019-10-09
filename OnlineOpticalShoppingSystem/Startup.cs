using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineOpticalShoppingSystem.Startup))]
namespace OnlineOpticalShoppingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
