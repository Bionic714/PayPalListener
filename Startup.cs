using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayPalListener.Startup))]
namespace PayPalListener
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
