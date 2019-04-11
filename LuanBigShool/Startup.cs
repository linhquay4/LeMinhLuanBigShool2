using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuanBigShool.Startup))]
namespace LuanBigShool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
