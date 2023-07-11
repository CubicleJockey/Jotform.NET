using Jotform.Models.Form;

namespace Jotform;

public partial class PostFormReports 
{
    public async Task<JotformResult<PostFormSubmissionsResponse[]>?> PutFormSubmissionsAsync(string formId, object responses, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync($"form/{formId}/submissions", responses, jsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<PostFormSubmissionsResponse[]>>(jsonSerializerOptions, cancellationToken: cancellationToken);
    }
}