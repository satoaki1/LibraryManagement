using Volo.Abp.Modularity;

namespace LibraryManagement;

public abstract class LibraryManagementApplicationTestBase<TStartupModule> : LibraryManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
