using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HabeshaCrafts.Startup))]
namespace HabeshaCrafts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
