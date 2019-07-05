using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using assignment.Authorization;

namespace assignment
{
    [DependsOn(
        typeof(assignmentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class assignmentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<assignmentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(assignmentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
