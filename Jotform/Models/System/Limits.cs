namespace Jotform.Models.System;

public class Limits
{
    [JsonPropertyName("submissions")]
    public int? Submissions { get; set; }

    [JsonPropertyName("overSubmissions")]
    public int? OverSubmissions { get; set; }

    [JsonPropertyName("sslSubmissions")]
    public int? SslSubmissions { get; set; }

    [JsonPropertyName("payments")]
    public int? Payments { get; set; }

    [JsonPropertyName("uploads")]
    public long? Uploads { get; set; }

    [JsonPropertyName("tickets")]
    public int? Tickets { get; set; }

    [JsonPropertyName("subusers")]
    public int? Subusers { get; set; }

    [JsonPropertyName("api-daily-limit")]
    public int? ApiDailyLimit { get; set; }

    [JsonPropertyName("views")]
    public int? Views { get; set; }

    [JsonPropertyName("formCount")]
    public int? FormCount { get; set; }

    [JsonPropertyName("hipaaCompliance")]
    public bool? HipaaCompliance { get; set; }

    [JsonPropertyName("emails")]
    public Emails Emails { get; set; }

    [JsonPropertyName("signedDocuments")]
    public int? SignedDocuments { get; set; }
}