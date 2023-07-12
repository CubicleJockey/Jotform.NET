using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Question>?> PostFormQuestionAsync(string formId, string questionId, Dictionary<string, string> questionDefinition, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();
        
        foreach (var (key, value) in questionDefinition)
        {
            formData.Add(key, value);
        }
        
        var response = await httpClient.PostAsync($"form/{formId}/question/{questionId}", formData.Build(), cancellationToken);
        
        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Question>>(JsonSerializerOptions, cancellationToken);
    }
}