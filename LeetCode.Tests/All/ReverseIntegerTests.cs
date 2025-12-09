using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class ReverseIntegerTests
{
    private readonly ReverseInteger _solution;

    public ReverseIntegerTests()
    {
        _solution = new ReverseInteger();
    }

    [Fact]
    public void Reverse_WithPositiveNumber_ReturnsReversed()
    {
        // 123 reversed is 321
        var result = _solution.Reverse(123);
        Assert.Equal(321, result);
    }

    [Fact]
    public void Reverse_WithNegativeNumber_ReturnsReversed()
    {
        // -123 reversed is -321
        var result = _solution.Reverse(-123);
        Assert.Equal(-321, result);
    }

    [Fact]
    public void Reverse_WithTrailingZeros_RemovesZeros()
    {
        // 120 reversed is 21 (trailing zero is removed)
        var result = _solution.Reverse(120);
        Assert.Equal(21, result);
    }

    [Fact]
    public void Reverse_WithSingleDigit_ReturnsSameNumber()
    {
        // Single digit numbers remain the same when reversed
        var result = _solution.Reverse(7);
        Assert.Equal(7, result);
    }
}
