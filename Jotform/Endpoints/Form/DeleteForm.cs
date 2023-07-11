namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Models.Form.Form>?> DeleteFormAsync(string formId, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.DeleteAsync($"form/{formId}", cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Form.Form>>(jsonSerializerOptions, cancellationToken);
    }
}