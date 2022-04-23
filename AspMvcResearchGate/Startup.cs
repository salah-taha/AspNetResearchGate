using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcResearchGate.Startup))]
namespace AspMvcResearchGate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
