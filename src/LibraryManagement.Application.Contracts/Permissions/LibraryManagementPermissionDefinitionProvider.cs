using LibraryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LibraryManagement.Permissions;

public class LibraryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LibraryManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(LibraryManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LibraryManagementResource>(name);
    }
}
