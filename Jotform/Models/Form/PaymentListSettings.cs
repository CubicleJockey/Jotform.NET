namespace Jotform.Models.Form;

public class PaymentListSetting
{
    [JsonPropertyName("minTotalOrderAmount")]
    public int MinTotalOrderAmount { get; set; }

    [JsonPropertyName("productCategories")]
    public string ProductCategories { get; set; }

    [JsonPropertyName("productListLayout")]
    public string ProductListLayout { get; set; }

    [JsonPropertyName("showCategory")]
    public bool ShowCategory { get; set; }

    [JsonPropertyName("showCategoryTitle")]
    public bool ShowCategoryTitle { get; set; }

    [JsonPropertyName("showMinTotalOrderAmount")]
    public bool ShowMinTotalOrderAmount { get; set; }

    [JsonPropertyName("showSearch")]
    public bool ShowSearch { get; set; }

    [JsonPropertyName("showSorting")]
    public bool ShowSorting { get; set; }
}