using Abp.Authorization;
using Agenda.Authorization.Roles;
using Agenda.Authorization.Users;

namespace Agenda.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
