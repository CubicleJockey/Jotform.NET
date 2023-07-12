using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Folder>?> GetFolderAsync(string folderId, CancellationToken cancellationToken = default) 
        => await httpClient.GetFromJsonAsync<JotformResult<Folder>>($"folder/{folderId}", 
            JsonSerializerOptions, cancellationToken);
}