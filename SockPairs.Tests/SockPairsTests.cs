namespace SockPairs.Tests;

public class SockPairsTests
{
    [Theory]
    [InlineData("AA", 1)]
    [InlineData("ABABC", 2)]
    [InlineData("CABBACCC", 4)]
    [InlineData("AACDE", 1)]
    [InlineData("ACDBE", 0)]
    [InlineData("", 0)]
    [InlineData("ABABAB", 2)]
    [InlineData("AAAAA", 2)]
    [InlineData("AAACCBB", 3)]
    public void TestGetPairsCountSuccess(string socks, int resultExpected)
    {
        var result = socks.GetPairsCount();
        Assert.Equal(resultExpected, result);
    }
}