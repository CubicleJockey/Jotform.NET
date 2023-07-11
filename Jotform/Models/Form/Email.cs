namespace Jotform.Models.Form;

public class Email
{
    [JsonPropertyName("body")]
    public string Body { get; set; }

    [JsonPropertyName("branding21Email")]
    public bool Branding21Email { get; set; }

    [JsonPropertyName("dirty")]
    public string Dirty { get; set; }

    [JsonPropertyName("from")]
    public string From { get; set; }

    [JsonPropertyName("hideEmptyFields")]
    public bool HideEmptyFields { get; set; }

    [JsonPropertyName("html")]
    public bool Html { get; set; }

    [JsonPropertyName("lastQuestionID")]
    public string LastQuestionID { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("pdfattachment")]
    public bool Pdfattachment { get; set; }

    [JsonPropertyName("pdfId")]
    public string PdfId { get; set; }

    [JsonPropertyName("replyTo")]
    public string ReplyTo { get; set; }

    [JsonPropertyName("sendOnEdit")]
    public bool SendOnEdit { get; set; }

    [JsonPropertyName("sendOnSubmit")]
    public bool SendOnSubmit { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    [JsonPropertyName("to")]
    public string To { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uniqueID")]
    public string UniqueID { get; set; }

    [JsonPropertyName("uploadAttachment")]
    public string UploadAttachment { get; set; }

    [JsonPropertyName("attachment")]
    public string Attachment { get; set; }

    [JsonPropertyName("sendDate")]
    public string SendDate { get; set; }
}