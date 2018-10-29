using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Agenda.Controllers
{
    public abstract class AgendaControllerBase: AbpController
    {
        protected AgendaControllerBase()
        {
            LocalizationSourceName = AgendaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
