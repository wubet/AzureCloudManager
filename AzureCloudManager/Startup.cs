using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureCloudManager.Startup))]
namespace AzureCloudManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
