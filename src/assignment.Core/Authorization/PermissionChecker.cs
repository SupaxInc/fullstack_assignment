using Abp.Authorization;
using assignment.Authorization.Roles;
using assignment.Authorization.Users;

namespace assignment.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
