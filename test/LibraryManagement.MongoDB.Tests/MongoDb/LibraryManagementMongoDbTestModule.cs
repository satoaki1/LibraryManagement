using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace LibraryManagement.MongoDB;

[DependsOn(
    typeof(LibraryManagementApplicationTestModule),
    typeof(LibraryManagementMongoDbModule)
)]
public class LibraryManagementMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = LibraryManagementMongoDbFixture.GetRandomConnectionString();
        });
    }
}
