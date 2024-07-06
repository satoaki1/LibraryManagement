using LibraryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LibraryManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LibraryManagementController : AbpControllerBase
{
    protected LibraryManagementController()
    {
        LocalizationResource = typeof(LibraryManagementResource);
    }
}
