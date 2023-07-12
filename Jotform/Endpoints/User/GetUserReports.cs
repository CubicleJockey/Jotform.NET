using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    // TODO: Returns pagination info, but does not take them as parameters
    public async Task<JotformResult<GetUserReportsResponse[]>?> GetUserReportsAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetUserReportsResponse[]>>("user/reports", JsonSerializerOptions, cancellationToken);
}