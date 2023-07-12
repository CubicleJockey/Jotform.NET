using Jotform.Models.Form;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<FormSubmission>?> GetSubmissionAsync(string submissionId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<FormSubmission>>($"submission/{submissionId}", 
            JsonSerializerOptions, cancellationToken);
}