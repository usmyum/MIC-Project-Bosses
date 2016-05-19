using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MICProject.Startup))]
namespace MICProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
