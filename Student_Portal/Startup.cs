using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Portal.Startup))]
namespace Student_Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
