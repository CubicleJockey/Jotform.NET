namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<string>?> DeleteSubmissionAsync(string submissionId, CancellationToken cancellationToken = default) 
        => await httpClient.DeleteFromJsonAsync<JotformResult<string>>($"submission/{submissionId}", 
            jsonSerializerOptions, cancellationToken);
}