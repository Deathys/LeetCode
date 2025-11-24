using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class ConfusingNumberTests
{
    private readonly ConfusingNumberSolution _solution;
    public ConfusingNumberTests()
    {
        _solution = new ConfusingNumberSolution();
    }

    [Fact]
    public void Do_WithZero_ReturnsFalse()
    {
        // Arrange & Act
        var result = _solution.ConfusingNumber(0);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Do_WithOne_ReturnsFalse()
    {
        // 1 rotated 180 degrees is still 1
        var result = _solution.ConfusingNumber(1);
        Assert.False(result);
    }

    [Fact]
    public void Do_WithEight_ReturnsFalse()
    {
        // 8 rotated 180 degrees is still 8
        var result = _solution.ConfusingNumber(8);
        Assert.False(result);
    }

    [Fact]
    public void Do_WithSix_ReturnsTrue()
    {
        // 6 rotated 180 degrees becomes 9
        var result = _solution.ConfusingNumber(6);
        Assert.True(result);
    }

    [Fact]
    public void Do_WithNine_ReturnsTrue()
    {
        // 9 rotated 180 degrees becomes 6
        var result = _solution.ConfusingNumber(9);
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(7)]
    public void Do_WithInvalidDigits_ReturnsFalse(int n)
    {
        // Numbers containing 2, 3, 4, 5, 7 cannot be rotated
        var result = _solution.ConfusingNumber(n);
        Assert.False(result);
    }

    [Fact]
    public void Do_With11_ReturnsFalse()
    {
        // 11 rotated is still 11
        var result = _solution.ConfusingNumber(11);
        Assert.False(result);
    }

    [Fact]
    public void Do_With69_ReturnsFalse()
    {
        // 69 rotated becomes 69 (same number, not confusing)
        var result = _solution.ConfusingNumber(69);
        Assert.False(result);
    }

    [Fact]
    public void Do_With88_ReturnsFalse()
    {
        // 88 rotated is still 88
        var result = _solution.ConfusingNumber(88);
        Assert.False(result);
    }

    [Fact]
    public void Do_With96_ReturnsFalse()
    {
        // 96 rotated becomes 96 (same number, not confusing)
        var result = _solution.ConfusingNumber(96);
        Assert.False(result);
    }

    [Fact]
    public void Do_With89_ReturnsTrue()
    {
        // Example 2: 89 rotated becomes 68 (68 != 89, confusing)
        var result = _solution.ConfusingNumber(89);
        Assert.True(result);
    }

    [Fact]
    public void Do_With25_ReturnsFalse()
    {
        // Contains invalid digits (2 and 5)
        var result = _solution.ConfusingNumber(25);
        Assert.False(result);
    }

    [Fact]
    public void Do_With818_ReturnsFalse()
    {
        // 818 rotated is still 818 (palindrome with valid digits)
        var result = _solution.ConfusingNumber(818);
        Assert.False(result);
    }

    [Fact]
    public void Do_With1001_ReturnsFalse()
    {
        // 1001 rotated is still 1001 (palindrome)
        var result = _solution.ConfusingNumber(1001);
        Assert.False(result);
    }

    [Fact]
    public void Do_With86_ReturnsTrue()
    {
        // 86 rotated becomes 98 (98 != 86, confusing)
        var result = _solution.ConfusingNumber(86);
        Assert.True(result);
    }

    [Fact]
    public void Do_With68_ReturnsTrue()
    {
        // 68 rotated becomes 89 (89 != 68, confusing)
        var result = _solution.ConfusingNumber(68);
        Assert.True(result);
    }
}
