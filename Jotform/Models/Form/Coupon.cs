namespace Jotform.Models.Form;

public class Coupon
{
    [JsonPropertyName("apply")]
    public string Apply { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("gatewayType")]
    public string GatewayType { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("limit")]
    public string Limit { get; set; }

    [JsonPropertyName("products")]
    public string Products { get; set; }

    [JsonPropertyName("rate")]
    public string Rate { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}