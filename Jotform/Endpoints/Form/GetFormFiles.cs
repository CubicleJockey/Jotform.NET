using Jotform.Models.Form;

namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<FormFile[]>?> GetFormFilesAsync(string formId, CancellationToken cancellationToken = default)
    {
        return await httpClient.GetFromJsonAsync<JotformResult<FormFile[]>>($"form/{formId}/files", jsonSerializerOptions, cancellationToken);
    }
}
