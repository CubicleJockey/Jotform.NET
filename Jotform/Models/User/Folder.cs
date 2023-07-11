namespace Jotform.Models.User;

public class Folder
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("parent")]
    public string Parent { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("forms")]
    public List<Form.Form> Forms { get; } = new();

    [JsonPropertyName("subfolders")]
    public List<Folder> Subfolders { get; } = new();
}