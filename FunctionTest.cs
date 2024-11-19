using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace EsepWebhook.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        dynamic json = JsonConvert.DeserializeObject<dynamic>(input.ToString());
        string payload = $"{{'text':'Issue Created: {json.issue.html_url}'}}";
        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var upperCase = function.FunctionHandler("hello world", context);

        Assert.Equal("HELLO WORLD", upperCase);
    }
}
