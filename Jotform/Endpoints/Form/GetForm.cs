namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Models.Form.Form>?> GetFormAsync(string formId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Models.Form.Form>>($"form/{formId}", 
            JsonSerializerOptions, cancellationToken: cancellationToken);
}