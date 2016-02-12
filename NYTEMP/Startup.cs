using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NYTEMP.Startup))]
namespace NYTEMP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
