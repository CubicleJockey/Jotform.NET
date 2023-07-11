﻿using Jotform.Models.Form;

namespace Jotform;

public partial class PostFormReports 
{
    public async Task<JotformResult<FormReport>?> GetReportAsync(string reportId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<FormReport>>($"report/{reportId}", 
            jsonSerializerOptions, cancellationToken);
}