﻿namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Dictionary<string, Question>>?> PutFormQuestionsAsync(string formId, object questions, CancellationToken cancellationToken = default)
    {
        var response = await httpClient.PutAsJsonAsync($"form/{formId}/questions", questions, jsonSerializerOptions, 
            cancellationToken: cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<Dictionary<string, Question>>>(jsonSerializerOptions, cancellationToken: cancellationToken);
    }
}