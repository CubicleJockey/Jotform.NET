using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient 
{
    public async Task<JotformResult<FormProperties>?> PutFormPropertiesAsync(string formId, object formProperties, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync($"form/{formId}/properties", formProperties, JsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<FormProperties>>(JsonSerializerOptions, cancellationToken: cancellationToken);
    }
}