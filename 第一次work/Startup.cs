using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(第一次work.Startup))]
namespace 第一次work
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
