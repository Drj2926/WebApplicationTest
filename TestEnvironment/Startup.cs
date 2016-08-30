using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestEnvironment.Startup))]
namespace TestEnvironment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
