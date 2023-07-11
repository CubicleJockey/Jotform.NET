namespace Jotform.Models.Form;

public class Product
{
    [JsonPropertyName("connectedCategories")]
    public string ConnectedCategories { get; set; }

    [JsonPropertyName("connectedProducts")]
    public string ConnectedProducts { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("fitImageToCanvas")]
    public bool FitImageToCanvas { get; set; }

    [JsonPropertyName("hasExpandedOption")]
    public string HasExpandedOption { get; set; }

    [JsonPropertyName("hasQuantity")]
    public string HasQuantity { get; set; }

    [JsonPropertyName("hasSpecialPricing")]
    public string HasSpecialPricing { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("images")]
    public string Images { get; set; }

    [JsonPropertyName("isLowStockAlertEnabled")]
    public bool IsLowStockAlertEnabled { get; set; }

    [JsonPropertyName("isStockControlEnabled")]
    public bool IsStockControlEnabled { get; set; }

    [JsonPropertyName("lowStockValue")]
    public string LowStockValue { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("options")]
    public string Options { get; set; }

    [JsonPropertyName("pid")]
    public string Pid { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("required")]
    public bool Required { get; set; }

    [JsonPropertyName("selected")]
    public bool Selected { get; set; }
}