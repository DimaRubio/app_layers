using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(app_layers.Startup))]
namespace app_layers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
