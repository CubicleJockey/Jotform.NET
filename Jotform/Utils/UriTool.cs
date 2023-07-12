namespace Jotform.Utils;

public class UriTool
{
    private readonly string baseUrl;
    private readonly IDictionary<string, string> parameters;

    public UriTool(string baseUrl)
    {
        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            throw new ArgumentException("Cannot be empty.", nameof(baseUrl));
        }

        if (!IsValidUri(baseUrl))
        {
            throw new($"{baseUrl} is an invalid url.");
        }

        this.baseUrl = baseUrl;
        parameters = new Dictionary<string, string>();
    }

    public UriTool AddQuery(string parameter, object? value)
    {
        return AddQuery(parameter, value?.ToString());
    }

    public UriTool AddQuery(string parameter, string? value)
    {
        if (value is null) { return this; }

        parameters[parameter] = value;

        return this;
    }

    public override string ToString()
    {
        var query = string.Join("&", parameters.Select(x => $"{x.Key}={x.Value}"));
        return string.IsNullOrWhiteSpace(query) ? baseUrl : $"{baseUrl}?{query}";
    }

    #region Helper Methods

    private static bool IsValidUri(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out var result) && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }

    #endregion Helper Methods
}