using Volo.Abp.Modularity;

namespace LibraryManagement;

[DependsOn(
    typeof(LibraryManagementDomainModule),
    typeof(LibraryManagementTestBaseModule)
)]
public class LibraryManagementDomainTestModule : AbpModule
{

}
