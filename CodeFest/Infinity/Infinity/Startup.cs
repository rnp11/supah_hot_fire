using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infinity.Startup))]
namespace Infinity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
