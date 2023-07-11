namespace Jotform.Models.User;

public class Permission
{
    /// <summary>
    /// type can be FORM, FOLDER or ALL.
    /// </summary>
    [JsonPropertyName("type")]
    public PermissionType Type { get; set; }

    /// <summary>
    /// resource_id is form ID or folder ID, depending on type.
    /// </summary>
    [JsonPropertyName("resource_id")]
    public string ResourceId { get; set; }

    /// <summary>
    /// access_type is full or readOnly. readOnly means form cannot be changed by the sub-user. Only submissions can be viewed.
    /// </summary>
    [JsonPropertyName("access_type")]
    public string AccessType { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}