using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Localization;
using Volo.Abp.Application.Services;

namespace LibraryManagement;

/* Inherit your application services from this class.
 */
public abstract class LibraryManagementAppService : ApplicationService
{
    protected LibraryManagementAppService()
    {
        LocalizationResource = typeof(LibraryManagementResource);
    }
}
