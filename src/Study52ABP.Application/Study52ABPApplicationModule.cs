using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Study52ABP.Authorization;

namespace Study52ABP
{
    [DependsOn(
        typeof(Study52ABPCoreModule),
        typeof(AbpAutoMapperModule))]
    public class Study52ABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Study52ABPAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                // XXXMapper.CreateMappers(configuration);


            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Study52ABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
