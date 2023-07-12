using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    /// <summary>
    /// Get User Information
    /// Get user account details for this Jotform user. Including user account type, avatar URL, name, email, website URL.
    /// </summary>
    public async Task<JotformResult<GetUserResponse>?> GetUserAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetUserResponse>>("user", 
            JsonSerializerOptions, cancellationToken: cancellationToken);
}