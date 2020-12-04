using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaginaPostres.Startup))]
namespace PaginaPostres
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
