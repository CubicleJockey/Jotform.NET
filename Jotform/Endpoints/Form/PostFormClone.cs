namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Models.Form.Form>?> PostFormCloneAsync(string formId, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PostAsync($"form/{formId}/clone", content: null, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Form.Form>>(jsonSerializerOptions, cancellationToken);
    }
}