using Abp.Authorization;
using Study52ABP.Authorization.Roles;
using Study52ABP.Authorization.Users;

namespace Study52ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
