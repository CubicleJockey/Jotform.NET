namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<string>?> DeleteFormQuestionAsync(string formId, string questionId, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.DeleteAsync($"form/{formId}/question/{questionId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<string>>(jsonSerializerOptions, cancellationToken);
    }
}