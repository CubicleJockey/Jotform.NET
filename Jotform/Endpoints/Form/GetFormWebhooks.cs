using System.Text.Json;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Dictionary<string, string>>?> GetFormWebhooksAsync(string formId, CancellationToken cancellationToken = default)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<JotformResult<Dictionary<string, string>>>($"form/{formId}/webhooks",
                JsonSerializerOptions, cancellationToken);
        }
        catch (JsonException)
        {
            return new();
        }
    }
}