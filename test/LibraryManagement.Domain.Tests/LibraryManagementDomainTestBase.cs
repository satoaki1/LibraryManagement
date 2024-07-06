using Volo.Abp.Modularity;

namespace LibraryManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class LibraryManagementDomainTestBase<TStartupModule> : LibraryManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
