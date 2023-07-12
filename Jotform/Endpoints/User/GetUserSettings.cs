namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<UserSettings>?> GetUserSettingsAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<UserSettings>>("user/settings", JsonSerializerOptions, cancellationToken: cancellationToken);
}
