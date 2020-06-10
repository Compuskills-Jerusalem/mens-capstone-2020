using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mens2020.Mvc.Startup))]
namespace Mens2020.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
