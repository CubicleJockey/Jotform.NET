namespace Jotform.Models.Shared;

public class Answer
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("order")]
    public string Order { get; set; }

    [JsonPropertyName("sublabels")]
    public string SubLabels { get; set; }

    /// <summary>
    /// text is the question label on the form
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("timeFormat")]
    public string TimeFormat { get; set; }

    /// <summary>
    /// type is the question type such as textbox or dropdown
    /// Most commonly used types are control_textbox, control_textarea, control_dropdown control_radio, control_checkbox, control_fileupload, control_fullname, control_email and control_datetime. Full List https://www.jotform.com/help/46-quick-overview-of-form-fields/
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// answer is the actual entry made by the submitter
    /// </summary>
    [JsonPropertyName("answer")]
    public object UserResponse { get; set; }

    [JsonPropertyName("prettyFormat")]
    public string? PrettyFormat { get; set; }
}