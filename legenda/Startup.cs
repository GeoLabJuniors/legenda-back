using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(legenda.Startup))]
namespace legenda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
