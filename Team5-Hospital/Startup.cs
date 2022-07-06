using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team5_Hospital.Startup))]
namespace Team5_Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
