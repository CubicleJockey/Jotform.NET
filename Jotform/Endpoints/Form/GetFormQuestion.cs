namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Question>?> GetFormQuestionAsync(string formId, string questionId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Question>>($"form/{formId}/question/{questionId}", 
            jsonSerializerOptions, cancellationToken);
}