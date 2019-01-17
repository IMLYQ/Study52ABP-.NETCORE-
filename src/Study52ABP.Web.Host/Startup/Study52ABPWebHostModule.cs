using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Study52ABP.Configuration;

namespace Study52ABP.Web.Host.Startup
{
    [DependsOn(
       typeof(Study52ABPWebCoreModule))]
    public class Study52ABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Study52ABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Study52ABPWebHostModule).GetAssembly());
        }
    }
}
