﻿using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient 
{
    public async Task<JotformResult<PostFormSubmissionsResponse[]>?> PutFormSubmissionsAsync(string formId, object responses, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync($"form/{formId}/submissions", responses, JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<PostFormSubmissionsResponse[]>>(JsonSerializerOptions, cancellationToken: cancellationToken);
    }
}