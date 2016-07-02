using Abp.Authorization;
using WexOne.Authorization.Roles;
using WexOne.MultiTenancy;
using WexOne.Users;

namespace WexOne.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
