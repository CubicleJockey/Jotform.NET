﻿using System.Text;
using System.Text.Json;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Models.Shared.Form>?> PutUserFormsAsync(object formDefinition, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PutAsJsonAsync("user/forms", formDefinition, _jsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Models.Shared.Form>>(_jsonSerializerOptions, cancellationToken);
    }
}