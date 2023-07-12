namespace Jotform;

public partial class JotformClient
{
    public async Task PutFormAsync(object formDefinition, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync("form", formDefinition, JsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}