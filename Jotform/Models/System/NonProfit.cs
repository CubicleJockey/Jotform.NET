namespace Jotform.Models.System;

public class NonProfit
{
    [JsonPropertyName("monthly")]
    public double? Monthly { get; set; }

    [JsonPropertyName("yearly")]
    public int? Yearly { get; set; }

    [JsonPropertyName("biyearly")]
    public int? Biyearly { get; set; }
}