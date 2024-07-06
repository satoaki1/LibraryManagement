using System.Threading.Tasks;

namespace LibraryManagement.Data;

public interface ILibraryManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
