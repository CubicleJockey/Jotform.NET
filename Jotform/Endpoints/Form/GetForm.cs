namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Models.Form.Form>?> GetFormAsync(string formId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Models.Form.Form>>($"form/{formId}", 
            jsonSerializerOptions, cancellationToken: cancellationToken);
}