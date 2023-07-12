﻿namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Models.Form.Form>?> PutUserFormsAsync(object formDefinition, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync("user/forms", formDefinition, JsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Form.Form>>(JsonSerializerOptions, cancellationToken);
    }
}