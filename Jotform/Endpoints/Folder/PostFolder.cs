using Jotform.Models.Form;
using Jotform.Models.User;

namespace Jotform;

public partial class JotformClient
{
    public async Task<JotformResult<Folder>?> PostFolderAsync(string folderName, string? parentId = null, string? colorHex = null, CancellationToken cancellationToken = default)
    {
        var formData = new FormDataBuilder();
        
        formData.Add("name", folderName);
        formData.Add("parent", parentId);
        formData.Add("color", colorHex);
        
        var response = await httpClient.PostAsync("folder", formData.Build(), cancellationToken);
        
        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<JotformResult<Folder>>(JsonSerializerOptions, cancellationToken);
    }
}