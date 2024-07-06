using LibraryManagement.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LibraryManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LibraryManagementMongoDbModule),
    typeof(LibraryManagementApplicationContractsModule)
    )]
public class LibraryManagementDbMigratorModule : AbpModule
{
}
