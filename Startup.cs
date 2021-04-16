using ALevelRealiseProject.Jobs;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALevelRealiseProject.Startup))]
namespace ALevelRealiseProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //var job = new CloseOrUpdateLoans();
            //job.UpdateLoansAfterTranzaction();
        }
    }
}
