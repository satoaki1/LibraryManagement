using LibraryManagement.Samples;
using Xunit;

namespace LibraryManagement.MongoDB.Domains;

[Collection(LibraryManagementTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<LibraryManagementMongoDbTestModule>
{

}
