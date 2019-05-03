using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SD_210_Assignment2.Startup))]
namespace SD_210_Assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
