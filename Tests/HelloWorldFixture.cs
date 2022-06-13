using NUnit.Framework;
using OpenFeature;
using Shouldly;

namespace Tests;

public class HelloWorldFixture
{
    [Test]
    public void EvaluateHelloWorldFlag()
    {
        var client = OpenFeatureAPI.GetClient();
        var value = client.GetBooleanValue("hello-world", true);
        
        value.ShouldBe(true);
    }
}