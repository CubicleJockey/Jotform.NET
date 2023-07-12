using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<FormReport>?> PostFormReportsAsync(string formId, string reportTitle, ListType listType, string[]? fields, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();
        
        formData.Add("title", reportTitle);
        formData.Add("list_type", listType.ToString());

        if (fields is not null)
        {
            formData.Add("fields", string.Join(",", fields));
        }
        
        var response = await httpClient.PostAsync($"form/{formId}/reports", formData.Build(), cancellationToken);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<JotformResult<FormReport>>(JsonSerializerOptions, cancellationToken);
    }
}