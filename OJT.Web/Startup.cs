using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OJT.Web.Startup))]
namespace OJT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
