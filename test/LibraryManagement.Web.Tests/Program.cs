using Microsoft.AspNetCore.Builder;
using LibraryManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<LibraryManagementWebTestModule>();

public partial class Program
{
}
