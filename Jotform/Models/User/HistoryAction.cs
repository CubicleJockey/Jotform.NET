namespace Jotform.Models.User;

public enum HistoryAction
{
    [JsonPropertyName("userCreation")]
    UserCreation,
    [JsonPropertyName("userLogin")]
    UserLogin,
    [JsonPropertyName("formCreation")]
    FormCreation,
    [JsonPropertyName("formUpdate")]
    FormUpdate,
    [JsonPropertyName("formDelete")]
    FormDelete,
    [JsonPropertyName("formPurge")]
    FormPurge
}