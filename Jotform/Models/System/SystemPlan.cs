namespace Jotform.Models.System;

public class SystemPlan
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("limits")]
    public Limits Limits { get; set; }

    [JsonPropertyName("prices")]
    public Prices Prices { get; set; }

    [JsonPropertyName("fastSpringURLs")]
    public FastSpringURLs FastSpringURLs { get; set; }

    [JsonPropertyName("onSale")]
    public OnSale OnSale { get; set; }

    [JsonPropertyName("planType")]
    public string PlanType { get; set; }

    [JsonPropertyName("currentPlanType")]
    public string CurrentPlanType { get; set; }
}