using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamProject15.Startup))]
namespace ExamProject15
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
