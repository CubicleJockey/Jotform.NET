namespace Jotform.Models.User;

public class GetUserSubmissionsResponse
{
    /// <summary>
    /// id is the Submission ID
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("form_id")]
    public string FormId { get; set; }

    /// <summary>
    /// ip address of the submitter
    /// </summary>
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// created_at, updated_at: YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// created_at, updated_at: YYYY-MM-DD HH:MM:SS
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// status can be ACTIVE or OVERQUOTA
    /// </summary>
    [JsonPropertyName("status")]
    public Status Status { get; set; }

    /// <summary>
    /// new is 1 if this submission is not read
    /// </summary>
    [JsonPropertyName("new")]
    public bool New { get; set; }

    [JsonPropertyName("answers")]
    public Dictionary<int, Answer> Answers { get; set; }
}