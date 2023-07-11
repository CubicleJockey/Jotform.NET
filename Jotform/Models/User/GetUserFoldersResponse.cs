namespace Jotform.Models.User;

public class GetUserFoldersResponse
{
    /// <summary>
    /// id is folder ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// path is list of folders above this folder separated with comma.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// parent is the next folder above. If this folder is a root folder parent returns itself.
    /// </summary>
    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    /// <summary>
    /// forms lists all forms under this folder.
    /// </summary>
    [JsonPropertyName("forms")]
    public Dictionary<string, Form.Form> Forms { get; set; }

    /// <summary>
    /// subfolders lists all folders under this folder.
    /// </summary>
    [JsonPropertyName("subfolders")]
    public List<Folder> Subfolders { get; } = new List<Folder>();
}