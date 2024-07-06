using Volo.Abp.Settings;

namespace LibraryManagement.Settings;

public class LibraryManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LibraryManagementSettings.MySetting1));
    }
}
