using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiDataApp.Startup))]
namespace PiDataApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
