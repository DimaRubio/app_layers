using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infopuls_les4_Second.Startup))]
namespace Infopuls_les4_Second
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
