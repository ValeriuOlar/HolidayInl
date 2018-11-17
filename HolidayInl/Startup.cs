using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HolidayInl.Startup))]
namespace HolidayInl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
