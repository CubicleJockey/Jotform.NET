﻿using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<FormReport[]>?> GetFormReportsAsync(string formId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<FormReport[]>>($"form/{formId}/reports", 
            jsonSerializerOptions, cancellationToken);
}