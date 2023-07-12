using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    /// <summary>
    /// Get Monthly User Usage
    /// Get number of form submissions received this month. Also, get number of SSL form submissions, payment form submissions and upload space used by user.
    /// </summary>
    public async Task<JotformResult<GetUserUsageResponse>?> GetUserUsageAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetUserUsageResponse>>("user/usage", 
            JsonSerializerOptions, cancellationToken: cancellationToken);
}