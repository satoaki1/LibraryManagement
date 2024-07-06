using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LibraryManagement.Data;

/* This is used if database provider does't define
 * ILibraryManagementDbSchemaMigrator implementation.
 */
public class NullLibraryManagementDbSchemaMigrator : ILibraryManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
