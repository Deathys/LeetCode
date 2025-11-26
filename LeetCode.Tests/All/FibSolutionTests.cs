using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class FibSolutionTests
{
    private readonly FibSolution _solution;

    public FibSolutionTests()
    {
        _solution = new FibSolution();
    }

    [Fact]
    public void Fib_WithZero_ReturnsZero()
    {
        // F(0) = 0
        var result = _solution.Fib(0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Fib_WithOne_ReturnsOne()
    {
        // F(1) = 1
        var result = _solution.Fib(1);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Fib_WithTwo_ReturnsOne()
    {
        // F(2) = 1
        var result = _solution.Fib(2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Fib_WithFive_ReturnsFive()
    {
        // F(5) = 5 (sequence: 0, 1, 1, 2, 3, 5)
        var result = _solution.Fib(5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Fib_WithTen_ReturnsFiftyFive()
    {
        // F(10) = 55
        var result = _solution.Fib(10);
        Assert.Equal(55, result);
    }

    [Fact]
    public void Fib_WithTwenty_ReturnsCorrectValue()
    {
        // F(20) = 6765
        var result = _solution.Fib(20);
        Assert.Equal(6765, result);
    }
}
