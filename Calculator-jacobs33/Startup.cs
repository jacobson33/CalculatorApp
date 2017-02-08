using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calculator_jacobs33.Startup))]
namespace Calculator_jacobs33
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
