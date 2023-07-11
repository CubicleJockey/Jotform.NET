namespace Jotform.Models.System;

public class AnnualPlans
{
    [JsonPropertyName("monthly")]
    public int? Monthly { get; set; }

    [JsonPropertyName("yearly")]
    public int? Yearly { get; set; }

    [JsonPropertyName("biyearly")]
    public int? Biyearly { get; set; }
}