using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSpa.Startup))]
namespace MVCSpa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
