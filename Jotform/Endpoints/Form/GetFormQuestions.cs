namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Dictionary<string, Question>>?> GetFormQuestionsAsync(string formId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Dictionary<string, Question>>>($"form/{formId}/questions",
            jsonSerializerOptions, cancellationToken: cancellationToken);
}