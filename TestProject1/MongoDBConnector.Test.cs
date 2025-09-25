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
        var result = connector.PingMongoDB(true);

        // Assert: verify the outcome
        Assert.True(result);
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange: create the connector
        var connector = new MongoDBConnector("name");

        // Act: call the method under test
        var result = connector.PingMongoDB(false);

        // Assert: verify the outcome
        Assert.False(result);
    }
}