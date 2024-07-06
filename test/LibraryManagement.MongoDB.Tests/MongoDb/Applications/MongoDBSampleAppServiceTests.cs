using LibraryManagement.MongoDB;
using LibraryManagement.Samples;
using Xunit;

namespace LibraryManagement.MongoDb.Applications;

[Collection(LibraryManagementTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<LibraryManagementMongoDbTestModule>
{

}
