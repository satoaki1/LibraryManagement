using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LibraryManagement.Pages;

public class Index_Tests : LibraryManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
