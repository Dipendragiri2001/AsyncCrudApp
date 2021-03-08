using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Learn.EntityFrameworkCore;
using Learn.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Learn.Web.Tests
{
    [DependsOn(
        typeof(LearnWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LearnWebTestModule : AbpModule
    {
        public LearnWebTestModule(LearnEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LearnWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LearnWebMvcModule).Assembly);
        }
    }
}