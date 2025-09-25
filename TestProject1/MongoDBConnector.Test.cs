namespace TestProject1;

using ClassLibrary1;
using Xunit;

public class MongoDBConnectorTest
{
    [Fact]
    public void Test1()
    {
        // Arrange: create the connector
        var connector = new MongoDBConnector("name");

        // Act: call the method under test
        var result = connector.PingMongoDB();

        // Assert: verify the outcome
        Assert.True(result);
    }
}