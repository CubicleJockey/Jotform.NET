namespace Jotform.Models.User;

public class GetSubUsersResponse
{
    /// <summary>
    /// owner the parent account that created this sub-user.
    /// </summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; }

    /// <summary>
    /// status can be LIVE, DELETED or PENDING. If the user has not accepted the invitation sub-user is in PENDING status.
    /// </summary>
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    /// <summary>
    /// created_at: YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("permissions")]
    public List<Permission> Permissions { get; } = new();
}