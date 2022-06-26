using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentLogin.Startup))]
namespace StudentLogin
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
