using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Guia1_DSE.Startup))]
namespace Guia1_DSE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
