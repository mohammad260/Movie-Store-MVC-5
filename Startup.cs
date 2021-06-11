using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movie_Store_MVC_5.Startup))]
namespace Movie_Store_MVC_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
