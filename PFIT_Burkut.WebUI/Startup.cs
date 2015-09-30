using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFIT_Burkut.WebUI.Startup))]
namespace PFIT_Burkut.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
