using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB02_1252016.Startup))]
namespace LAB02_1252016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
