using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<PostFormSubmissionsResponse>?> PostFormSubmissionsAsync(string formId, Dictionary<string, string> responses, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();
        
        foreach (var (key, value) in responses)
        {
            formData.Add(key, value);
        }
        
        var response = await httpClient.PostAsync($"form/{formId}/submissions", formData.Build(), cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<PostFormSubmissionsResponse>>(JsonSerializerOptions, cancellationToken);
    }
}