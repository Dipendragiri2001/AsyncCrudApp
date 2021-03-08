using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Learn.Authorization;

namespace Learn
{
    [DependsOn(
        typeof(LearnCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LearnApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LearnAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LearnApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
