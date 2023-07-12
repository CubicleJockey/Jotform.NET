namespace Jotform.Tests.Endpoints.Folder;

[TestClass]
public class DeleteFolderTests : BaseTestEndpoint
{
    public DeleteFolderTests()
    {
        A.CallTo(async () => await fakeHttpClient.DeleteAsync($"{fakeHttpClient.BaseAddress}folder/1"))

    }

    [TestMethod]
    public async Task DeleteFolder_Success()
    {

    }
}