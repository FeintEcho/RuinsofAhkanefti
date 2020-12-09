using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RuinsofAhkanefti.Startup))]
namespace RuinsofAhkanefti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
