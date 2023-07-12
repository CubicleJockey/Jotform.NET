namespace Jotform.Tests.Endpoints;

public abstract class BaseTestEndpoint
{
    protected readonly HttpClient fakeHttpClient;

    protected BaseTestEndpoint()
    {
        fakeHttpClient = A.Fake<HttpClient>();
    }

    #region Helper Methods

    protected void ClearBaseFakes()
    {
        Fake.ClearRecordedCalls(fakeHttpClient);
    }

    #endregion Helper Methods
}