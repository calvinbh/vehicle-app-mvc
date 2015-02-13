using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week4_Vehicle_App.Startup))]
namespace Week4_Vehicle_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
