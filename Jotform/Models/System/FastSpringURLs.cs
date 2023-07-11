namespace Jotform.Models.System;

public class FastSpringURLs
{
    [JsonPropertyName("monthly")]
    public string Monthly { get; set; }

    [JsonPropertyName("yearly")]
    public string Yearly { get; set; }

    [JsonPropertyName("biyearly")]
    public string Biyearly { get; set; }
}