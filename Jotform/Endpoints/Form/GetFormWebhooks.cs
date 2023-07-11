using System.Text.Json;

namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Dictionary<string, string>>?> GetFormWebhooksAsync(string formId, CancellationToken cancellationToken = default)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<JotformResult<Dictionary<string, string>>>($"form/{formId}/webhooks",
                jsonSerializerOptions, cancellationToken);
        }
        catch (JsonException)
        {
            return new();
        }
    }
}