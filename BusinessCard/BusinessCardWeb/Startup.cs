using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessCardWeb.Startup))]
namespace BusinessCardWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
