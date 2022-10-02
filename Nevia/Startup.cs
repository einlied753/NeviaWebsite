using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nevia.Startup))]
namespace Nevia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
