using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExternalLogin.Startup))]
namespace ExternalLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseFacebookAuthentication(appId: "743297313971645", appSecret: "41c72fabf553507454494c9f39e4f3a3");
        }
    }
}
