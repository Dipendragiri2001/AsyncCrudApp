using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Learn.Controllers
{
    public abstract class LearnControllerBase: AbpController
    {
        protected LearnControllerBase()
        {
            LocalizationSourceName = LearnConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
