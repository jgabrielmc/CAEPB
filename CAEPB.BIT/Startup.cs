using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAEPB.BIT.Startup))]
namespace CAEPB.BIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
