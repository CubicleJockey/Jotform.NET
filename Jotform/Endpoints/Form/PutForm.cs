namespace Jotform;

public partial class JotformClient
{
    public async Task PutFormAsync(object formDefinition, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync("form", formDefinition, jsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
    }
}