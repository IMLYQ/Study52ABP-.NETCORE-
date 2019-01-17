using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Study52ABP.Controllers
{
    public abstract class Study52ABPControllerBase: AbpController
    {
        protected Study52ABPControllerBase()
        {
            LocalizationSourceName = Study52ABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
