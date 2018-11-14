using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MAP_MVC.Startup))]
namespace MAP_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
