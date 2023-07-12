using System.Text.Json.Serialization;
using Jotform.Models.Shared;
using Jotform.Utils;

namespace Jotform.Tests.Utils;

[TestClass]
public class AnswerDictionaryExtensionsTests
{
    private readonly IDictionary<int, Answer> answers;

    public AnswerDictionaryExtensionsTests()
    {
        answers = new Dictionary<int, Answer>
        {
            {1, new() { Name = "StringItem", UserResponse = "UserAnswer"} },
            {2, new() { Name = "CustomObject", UserResponse = new ThingyDate{ Month = "05", Day = "10", Year = "2023", DateTime = "2023-05-10 00:00:00"}} },
            {3, new() { Name = "Number", UserResponse = 1_000_000 } },
            {4, new() { Name = "CustomObjectAsJson", UserResponse = " {\"month\":\"05\",\"day\":\"16\",\"year\":\"2023\"}" } }
        };
    }


    [DataTestMethod]
    public void GetAnswer_NotFound()
    {
        const string Name = "NotFound";
        var first = answers.GetAnswerValueByName<int>(Name);
        first.Should().Be(default);
    }

    [TestMethod]
    public void GetAnswerAsString()
    {
        //Arrange & Act
        var answer = answers.GetAnswerValueByName<string>("StringItem");

        //Assert
        answer.Should().NotBeNullOrWhiteSpace();
        answer.Should().Be("UserAnswer");
    }

    [TestMethod]
    public void GetCustomObject()
    {
        //Arrange & Act
        var answer = answers.GetAnswerValueByName<ThingyDate>("CustomObject");

        //Assert
        answer.Should().NotBeNull();
        answer.Month.Should().Be("05");
        answer.Day.Should().Be("10");
        answer.Year.Should().Be("2023");
        answer.DateTime.Should().Be("2023-05-10 00:00:00");
    }

    [TestMethod]
    public void GetIntObject()
    {
        var answer = answers.GetAnswerValueByName<int>("Number");
        answer.Should().Be(1000000);
    }

    [TestMethod]
    public void GetCustomObjectFromJson()
    {
        //Arrange & Act
        var answer = answers.GetAnswerValueByName<ThingyDate>("CustomObjectAsJson", true, JotformClient.JsonSerializerOptions);

        //Assert
        answer.Should().NotBeNull();
        answer.Month.Should().Be("05");
        answer.Day.Should().Be("16");
        answer.Year.Should().Be("2023");
        answer.DateTime.Should().BeNullOrWhiteSpace();
    }

    #region Helper Classes

    private class ThingyDate
    {
        [JsonPropertyName("month")]
        public string Month { get; init; }

        [JsonPropertyName("day")]
        public string Day { get; init; }

        [JsonPropertyName("year")]
        public string Year { get; init; }

        [JsonPropertyName("datetime")]
        public string DateTime { get; init; }
    }

    #endregion Helper Classes
}