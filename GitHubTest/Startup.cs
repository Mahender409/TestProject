using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTest.Startup))]
namespace GitHubTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
