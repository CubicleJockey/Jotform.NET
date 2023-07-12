using System.Text.Json;
using Jotform.Json;

namespace Jotform;

public partial class JotformClient
{
    private readonly string apiKey;
    private readonly HttpClient httpClient;
    
    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        Converters =
        {
            new JsonStringEnumConverter(),
            new IntBoolConverter()
        },
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };
    
    public string BaseUrl { get; init; }

    /// <summary>
    /// Create a new Jotform Client
    /// </summary>
    /// <param name="apiKey">Obtain an api key at https://www.jotform.com/myaccount/api</param>
    /// <param name="enterpriseSubDomain">For enterprise users, use 'SUBDOMAIN', from the string: 'SUBDOMAIN.jotform.com/API'</param>
    /// <param name="httpClient">Override HttpClient with custom settings if needed.</param>
    public JotformClient(string apiKey, string? enterpriseSubDomain = default!, HttpClient httpClient = default!)
    {
        if (string.IsNullOrWhiteSpace(apiKey)) { throw new ArgumentException("Cannot be empty.", nameof(apiKey)); }

        this.apiKey = apiKey;
        
        BaseUrl = enterpriseSubDomain != null
            ? $"https://{enterpriseSubDomain}.jotform.com/api"
            : "https://api.jotform.com";

        if (httpClient != default)
        {
            this.httpClient = httpClient;
        }
        else
        {
            this.httpClient = new()
            {
                BaseAddress = new(BaseUrl),
                DefaultRequestHeaders =
                {
                    { "apiKey", this.apiKey }
                }
            };
        }
    }
}