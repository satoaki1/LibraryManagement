using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LibraryManagement.Web;

[Dependency(ReplaceServices = true)]
public class LibraryManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LibraryManagement";
}
