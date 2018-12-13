using Abp.Authorization;
using ABPDemoProject.Authorization.Roles;
using ABPDemoProject.Authorization.Users;

namespace ABPDemoProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
