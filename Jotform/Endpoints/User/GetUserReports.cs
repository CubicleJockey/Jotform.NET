namespace Jotform;

public partial class PostFormReports
{
    // TODO: Returns pagination info, but does not take them as parameters
    public async Task<JotformResult<GetUserReportsResponse[]>?> GetUserReportsAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetUserReportsResponse[]>>("user/reports", jsonSerializerOptions, cancellationToken);
}