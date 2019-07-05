using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace assignment.Controllers
{
    public abstract class assignmentControllerBase: AbpController
    {
        protected assignmentControllerBase()
        {
            LocalizationSourceName = assignmentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
