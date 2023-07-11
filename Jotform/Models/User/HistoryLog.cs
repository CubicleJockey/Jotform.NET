namespace Jotform.Models.User;

public class HistoryLog
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("formID")]
    public string FormID { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("formTitle")]
    public string FormTitle { get; set; }

    [JsonPropertyName("formStatus")]
    public string FormStatus { get; set; }

    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    /// <summary>
    /// timestamp is number of seconds since Jan 1st, 1970.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public int Timestamp { get; set; }
}