namespace Jotform.Models.User;

public class GetUserUsageResponse
{
    /// <summary>
    /// Number of submissions received this month
    /// </summary>
    [JsonPropertyName("submissions")]
    public int Submissions { get; set; }

    /// <summary>
    /// Number of secure submissions received this month
    /// </summary>
    [JsonPropertyName("ssl_submissions")]
    public int SslSubmissions { get; set; }

    /// <summary>
    /// Number of payment submissions received this month
    /// </summary>
    [JsonPropertyName("payments")]
    public int Payments { get; set; }

    /// <summary>
    /// Total disk space used for uploaded files. In bytes.
    /// </summary>
    [JsonPropertyName("uploads")]
    public int Uploads { get; set; }

    /// <summary>
    /// Number of mobile submissions received this month
    /// </summary>
    [JsonPropertyName("mobile_submissions")]
    public int MobileSubmissions { get; set; }

    /// <summary>
    /// Number of form views received this month
    /// </summary>
    [JsonPropertyName("views")]
    public int Views { get; set; }

    /// <summary>
    /// Number of api calls used today.
    /// </summary>
    [JsonPropertyName("api")]
    public int Api { get; set; }
}