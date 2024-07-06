using Volo.Abp.Modularity;

namespace LibraryManagement;

[DependsOn(
    typeof(LibraryManagementApplicationModule),
    typeof(LibraryManagementDomainTestModule)
)]
public class LibraryManagementApplicationTestModule : AbpModule
{

}
