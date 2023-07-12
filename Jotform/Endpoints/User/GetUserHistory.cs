using Jotform.Models.User;
using Jotform.Utils;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<HistoryLog[]>?> GetUserHistoryAsync(HistoryAction? action = null, HistoryDate? date = null, string? startDate = null, string? endDate = null, CancellationToken cancellationToken = default)
    {
        var url = new UriTool("user/history")
            .AddQuery("action", action)
            .AddQuery("date", date)
            .AddQuery("startDate", startDate)
            .AddQuery("endDate", endDate)
            .ToString();

        return await httpClient.GetFromJsonAsync<JotformResult<HistoryLog[]>>(url, JsonSerializerOptions, cancellationToken);
    }
}