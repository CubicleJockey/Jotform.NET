namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Models.Form.Form>?> PutUserFormsAsync(object formDefinition, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync("user/forms", formDefinition, jsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Form.Form>>(jsonSerializerOptions, cancellationToken);
    }
}