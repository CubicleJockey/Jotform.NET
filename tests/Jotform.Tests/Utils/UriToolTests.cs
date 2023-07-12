using Jotform.Utils;

namespace Jotform.Tests.Utils;

[TestClass]
public class UriToolTests
{
    private readonly IDictionary<int, IList<(string param, object value)>> ObjectParameters;
    private readonly IDictionary<int, IList<(string param, string value)>> StringParameters;

    public UriToolTests()
    {
        ObjectParameters = new Dictionary<int, IList<(string param, object value)>>
        {
            { 1, Array.Empty<(string param, object value)>() },
            { 2, new List<(string param, object value)>
                {
                    ("a", 1),
                    ("b", "hi")
                }
            }
        };

        StringParameters = new Dictionary<int, IList<(string param, string value)>>
        {
            { 1, Array.Empty<(string param, string value)>() },
            { 2, new List<(string param, string value)>
                {
                    ("a", "1"),
                    ("b", "hi")
                }
            }
        };
    }

    [DataRow(null)]
    [DataRow(default)]
    [DataRow("")]
    [DataRow("                ")]
    [DataTestMethod]
    public void Ctor_BaseUrlIsEmpty(string baseUrl)
    {
        var ctor = () => _ = new UriTool(baseUrl);
        ctor.Should()
            .Throw<ArgumentException>()
            .WithMessage("Cannot be empty. (Parameter 'baseUrl')");
    }

    [DataRow("htp://www.badurl.com")]
    [DataRow("hpps://anotherbadurl.com")]
    [DataRow("just a sentence")]
    [DataTestMethod]
    public void Ctor_InvalidUrls(string baseUrl)
    {
        var ctor = () => _ = new UriTool(baseUrl);
        ctor.Should()
            .Throw<Exception>()
            .WithMessage($"{baseUrl} is an invalid url.");
    }

    [TestMethod]
    public void Ctor_IsValid()
    {
        var uriTool = new UriTool("https://www.awesome.com");
        uriTool.Should().NotBeNull();
    }

    [DataRow(1, "https://www.awesome.com")]
    [DataRow(2, "https://www.awesome.com?a=1&b=hi")]
    [DataTestMethod]
    public void AddQuery_Object_ToString(int scenario, string expected)
    {
        //Arrange
        var parameters = ObjectParameters[scenario];
        var uriTool = new UriTool("https://www.awesome.com");
        foreach (var (parameter, value) in parameters)
        {
            uriTool.AddQuery(parameter, value);
        }

        //Act & Assert
        uriTool.ToString().Should().Be(expected);
    }

    [DataRow(1, "https://www.awesome.com")]
    [DataRow(2, "https://www.awesome.com?a=1&b=hi")]
    [DataTestMethod]
    public void AddQuery_String_ToString(int scenario, string expected)
    {
        //Arrange
        var parameters = ObjectParameters[scenario];
        var uriTool = new UriTool("https://www.awesome.com");
        foreach (var (parameter, value) in parameters)
        {
            uriTool.AddQuery(parameter, value);
        }

        //Act & Assert
        uriTool.ToString().Should().Be(expected);
    }
}