namespace Explorations.Pipelines.Extensions.Tests;

public class EnumerableExtensionsTests
{
    [Fact]
    public void ReturnsEmpty_WhenNull()
    {
        IEnumerable<string>? enumerable = null;

        var sut = enumerable.EmptyIfNull();
        
        Assert.NotNull(sut);
        Assert.Equal(sut, Array.Empty<string>());
    }
    
    [Fact]
    public void ReturnsSource_WhenNotNull()
    {
        IEnumerable<string> enumerable = ["a", "b"];

        var sut = enumerable.EmptyIfNull();
        
        Assert.NotNull(sut);
        Assert.Equal(sut, enumerable);
    }
}