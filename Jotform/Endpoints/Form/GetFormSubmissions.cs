using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<PagedJotformResult<FormSubmission>?> GetFormSubmissionsAsync(string formId, int? offset = null, int? limit = null, string? filter = null, string? orderBy = null, CancellationToken cancellationToken = default)
    {
        var url = new UriBuilder($"form/{formId}/submissions")
            .AddQuery("offset", offset)
            .AddQuery("limit", limit)
            .AddQuery("filter", filter)
            .AddQuery("orderby", orderBy);

        return await httpClient.GetFromJsonAsync<PagedJotformResult<FormSubmission>>(url.ToString(), JsonSerializerOptions, cancellationToken);
    }
}