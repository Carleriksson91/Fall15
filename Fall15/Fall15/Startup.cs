using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fall15.Startup))]
namespace Fall15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
