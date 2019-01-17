using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Study52ABP.Authorization
{
    public class Study52ABPAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, Study52ABPConsts.LocalizationSourceName);
        }
    }
}
