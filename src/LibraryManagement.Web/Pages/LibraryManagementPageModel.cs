using LibraryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LibraryManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LibraryManagementPageModel : AbpPageModel
{
    protected LibraryManagementPageModel()
    {
        LocalizationResourceType = typeof(LibraryManagementResource);
    }
}
