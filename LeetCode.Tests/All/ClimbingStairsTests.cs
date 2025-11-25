using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class ClimbingStairsTests
{
    private readonly ClimbingStairsSolution _solution;

    public ClimbingStairsTests()
    {
        _solution = new ClimbingStairsSolution();
    }

    [Fact]
    public void ClimbStairs_WithOneStep_ReturnsOne()
    {
        // Only one way: 1 step
        var result = _solution.ClimbStairs(1);
        Assert.Equal(1, result);
    }

    [Fact]
    public void ClimbStairs_WithTwoSteps_ReturnsTwo()
    {
        // Two ways: (1+1) or (2)
        var result = _solution.ClimbStairs(2);
        Assert.Equal(2, result);
    }

    [Fact]
    public void ClimbStairs_WithThreeSteps_ReturnsThree()
    {
        // Three ways: (1+1+1), (1+2), (2+1)
        var result = _solution.ClimbStairs(3);
        Assert.Equal(3, result);
    }

    [Fact]
    public void ClimbStairs_WithFourSteps_ReturnsFive()
    {
        // Five ways: (1+1+1+1), (1+1+2), (1+2+1), (2+1+1), (2+2)
        var result = _solution.ClimbStairs(4);
        Assert.Equal(5, result);
    }

    [Fact]
    public void ClimbStairs_WithFiveSteps_ReturnsEight()
    {
        // Eight ways (Fibonacci sequence)
        var result = _solution.ClimbStairs(5);
        Assert.Equal(8, result);
    }

    [Fact]
    public void ClimbStairs_WithLargerNumber_ReturnsCorrectValue()
    {
        // Test with n=10 (should return 89)
        var result = _solution.ClimbStairs(10);
        Assert.Equal(89, result);
    }
}
