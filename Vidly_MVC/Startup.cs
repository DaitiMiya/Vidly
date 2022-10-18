using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_MVC.Startup))]
namespace Vidly_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
