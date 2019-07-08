using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace assignment.Authorization
{
    public class assignmentAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            // We only want the host to see the contents page
            context.CreatePermission(PermissionNames.Pages_Contents, L("Contents"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, assignmentConsts.LocalizationSourceName);
        }
    }
}
