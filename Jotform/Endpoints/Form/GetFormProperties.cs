using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<FormProperties>?> GetFormPropertiesAsync(string formId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<FormProperties>>($"form/{formId}/properties", 
            JsonSerializerOptions, cancellationToken);
}