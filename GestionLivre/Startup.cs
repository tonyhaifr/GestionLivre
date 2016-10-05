using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionSach.Startup))]
namespace GestionSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
