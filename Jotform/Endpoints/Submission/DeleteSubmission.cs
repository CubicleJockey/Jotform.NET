namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<string>?> DeleteSubmissionAsync(string submissionId, CancellationToken cancellationToken = default) 
        => await httpClient.DeleteFromJsonAsync<JotformResult<string>>($"submission/{submissionId}", 
            jsonSerializerOptions, cancellationToken);
}