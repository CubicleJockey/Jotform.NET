namespace Jotform.Tests;

[TestClass]
public class CreateClientTests
{
    [DataRow(null)]
    [DataRow("")]
    [DataRow("                      ")]
    [DataTestMethod]
    public void Ctor_NoApiKey_IsInvalid(string apiKey)
    {
        var ctor = () => _ = new JotformClient(apiKey);
        ctor.Should()
            .Throw<ArgumentException>()
            .WithMessage("Cannot be empty. (Parameter 'apiKey')");
    }

    [TestMethod]
    public void Ctor_ApiKey_IsValid()
    {
        // Act
        var ctor  = () => _ =  new JotformClient(Guid.NewGuid().ToString());
        
        // Assert
        ctor.Should()
            .NotThrow();
    }

    [TestMethod]
    public void Ctor_ApiKeyAndSubDomain_IsValid()
    {
        // Act
        var ctor = () => _  = new JotformClient(Guid.NewGuid().ToString(), "subdomain");
        
        // Assert
        ctor.Should()
            .NotThrow();
    }
}