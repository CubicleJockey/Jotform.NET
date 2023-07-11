using Jotform.Models.User;

namespace Jotform;

public partial class PostFormReports
{
    /// <summary>
    /// Get User Submissions
    /// Get a list of all submissions for all forms on this account. The answers array has the submission data. Created_at is the date of the submission.
    /// </summary>
    public async Task<PagedJotformResult<GetUserSubmissionsResponse>?> GetUserSubmissionsAsync(int? offset = null, int? limit = null, string? filter = null, string? orderBy = null, CancellationToken cancellationToken = default)
    {
        var url = new UriBuilder("user/submissions")
            .AddQuery("offset", offset)
            .AddQuery("limit", limit)
            .AddQuery("filter", filter)
            .AddQuery("orderby", orderBy);

        return await httpClient.GetFromJsonAsync<PagedJotformResult<GetUserSubmissionsResponse>>(url.ToString(), jsonSerializerOptions, cancellationToken);
    }
}