using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestIdentityFramework.Startup))]
namespace TestIdentityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
