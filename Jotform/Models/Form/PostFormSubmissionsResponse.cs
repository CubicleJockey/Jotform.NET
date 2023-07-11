namespace Jotform.Models.Form;

public class PostFormSubmissionsResponse
{
    [JsonPropertyName("submissionID")]
    public string SubmissionID { get; set; }

    [JsonPropertyName("URL")]
    public string URL { get; set; }
}