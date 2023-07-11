using Jotform.Models.System;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<SystemPlan>?> GetSystemPlanAsync(SystemPlanType plan, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<SystemPlan>>($"system/plan/{plan.ToString().ToUpper()}", 
            jsonSerializerOptions, cancellationToken: cancellationToken);
}