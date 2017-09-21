using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoRentingSystem.Startup))]
namespace VideoRentingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
