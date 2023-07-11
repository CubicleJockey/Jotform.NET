namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<UserSettings>?> GetUserSettingsAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<UserSettings>>("user/settings", jsonSerializerOptions, cancellationToken: cancellationToken);
}
