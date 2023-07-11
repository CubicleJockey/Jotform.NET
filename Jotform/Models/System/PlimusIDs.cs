namespace Jotform.Models.System;

public class PlimusIDs
{
    [JsonPropertyName("monthly")]
    public int? Monthly { get; set; }

    [JsonPropertyName("yearly")]
    public int? Yearly { get; set; }

    [JsonPropertyName("biyearly")]
    public int? Biyearly { get; set; }

    [JsonPropertyName("biyearly-single")]
    public int? BiyearlySingle { get; set; }
}