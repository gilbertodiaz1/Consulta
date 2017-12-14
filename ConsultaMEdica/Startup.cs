using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsultaMEdica.Startup))]
namespace ConsultaMEdica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
