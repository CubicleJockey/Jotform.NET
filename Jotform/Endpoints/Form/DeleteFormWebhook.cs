using System.Text.Json;

namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Dictionary<string, string>>?> DeleteFormWebhookAsync(string formId, string webhookId, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.DeleteAsync($"form/{formId}/webhooks/{webhookId}", cancellationToken);
        
        response.EnsureSuccessStatusCode();

        try
        {
            return await response.Content.ReadFromJsonAsync<JotformResult<Dictionary<string, string>>>(jsonSerializerOptions, cancellationToken);
        }
        catch (JsonException)
        {
            return new JotformResult<Dictionary<string, string>>();
        }
    }
}