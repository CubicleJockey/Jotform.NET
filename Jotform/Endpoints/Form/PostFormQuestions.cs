using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Question>?> PostFormQuestionsAsync(string formId, Dictionary<string, string> questionDefinition, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();
        
        foreach (var (key, value) in questionDefinition)
        {
            formData.Add(key, value);
        }

        var response = await httpClient.PostAsJsonAsync($"form/{formId}/questions", formData, JsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<Question>>(JsonSerializerOptions, cancellationToken);
    }
}