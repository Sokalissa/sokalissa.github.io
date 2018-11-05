using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoxieGospelChorale.Startup))]
namespace MoxieGospelChorale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
