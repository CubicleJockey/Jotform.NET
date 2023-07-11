using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<GetSubUsersResponse[]>?> GetSubUsersAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetSubUsersResponse[]>>("user/subusers", jsonSerializerOptions, cancellationToken: cancellationToken);
}