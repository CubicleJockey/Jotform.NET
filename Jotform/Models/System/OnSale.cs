namespace Jotform.Models.System;

public class OnSale
{
    [JsonPropertyName("prices")]
    public Prices Prices { get; set; }

    [JsonPropertyName("plimusIDs")]
    public PlimusIDs PlimusIDs { get; set; }

    [JsonPropertyName("nonProfit")]
    public NonProfit NonProfit { get; set; }

    [JsonPropertyName("campaigns")]
    public Campaigns Campaigns { get; set; }
}