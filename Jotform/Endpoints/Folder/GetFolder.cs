namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<Folder>?> GetFolderAsync(string folderId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Folder>>($"folder/{folderId}", 
            jsonSerializerOptions, cancellationToken);
}