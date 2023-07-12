using Jotform.Utils;

namespace Jotform;

public partial class JotformClient
{
    /// <summary>
    /// Get User Forms
    /// Get a list of forms for this account. Includes basic details such as title of the form, when it was created, number of new and total submissions.
    /// </summary>
    public async Task<PagedJotformResult<Models.Form.Form>?> GetUserFormsAsync(int? offset = null, int? limit = null, string? jsonFilter = null, string? orderBy = null, CancellationToken cancellationToken = default)
    {
        var url = new UriTool("user/forms")
            .AddQuery("offset", offset)
            .AddQuery("limit", limit)
            .AddQuery("jsonFilter", jsonFilter)
            .AddQuery("orderBy", orderBy)
            .ToString();

        return await httpClient.GetFromJsonAsync<PagedJotformResult<Models.Form.Form>>(url, JsonSerializerOptions, cancellationToken);
    }
}