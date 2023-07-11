namespace Jotform.Models.User;

public enum HistoryDate
{
    [JsonPropertyName("lastWeek")]
    LastWeek,
    [JsonPropertyName("lastMonth")]
    LastMonth,
    [JsonPropertyName("last3Months")]
    Last3Months,
    [JsonPropertyName("last6Months")]
    Last6Months,
    [JsonPropertyName("lastYear")]
    LastYear,
    [JsonPropertyName("all")]
    All
}