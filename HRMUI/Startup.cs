using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRMUI.Startup))]
namespace HRMUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
