using Abp.Authorization;
using Learn.Authorization.Roles;
using Learn.Authorization.Users;

namespace Learn.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
