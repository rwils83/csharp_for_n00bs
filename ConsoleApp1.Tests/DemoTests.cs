namespace ConsoleApp1.Tests;

public class DemoTests
{
    [Fact]
    public void GetThirdElement_ReturnsTheElementAtIndexTwo()
    {
        var result = Demo.GetThirdElement(new[] { 1, 2, 3, 4, 5 });

        Assert.Equal(3, result);
    }

    [Fact]
    public void GetThirdElement_ThrowsWhenArrayHasFewerThanThreeElements()
    {
        Assert.Throws<ArgumentException>(() => Demo.GetThirdElement(new[] { 1, 2 }));
    }

    [Fact]
    public void DescribeTuple_FormatsAllThreeValues()
    {
        var result = Demo.DescribeTuple(("String 1", "String 2", 10));

        Assert.Equal("String 1 / String 2 (count: 10)", result);
    }
}
