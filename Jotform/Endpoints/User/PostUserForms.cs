using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Models.Form.Form>?> PostUserFormsAsync(Dictionary<string, string> formDefinition, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();

        foreach (var (key, value) in formDefinition)
        {
            formData.Add(key, value);
        }
        
        var response = await httpClient.PostAsync("user/forms", 
            formData.Build(), cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Form.Form>>(jsonSerializerOptions, cancellationToken);
    }
}