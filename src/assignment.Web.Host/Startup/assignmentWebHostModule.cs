using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using assignment.Configuration;

namespace assignment.Web.Host.Startup
{
    [DependsOn(
       typeof(assignmentWebCoreModule))]
    public class assignmentWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public assignmentWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(assignmentWebHostModule).GetAssembly());
        }
    }
}
