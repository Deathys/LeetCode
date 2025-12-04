using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class CountCollisionsOnARoadTests
{
    private readonly CountCollisionsOnARoad _solution;

    public CountCollisionsOnARoadTests()
    {
        _solution = new CountCollisionsOnARoad();
    }

    [Fact]
    public void CountCollisions_WithRightLeftCollision_ReturnsTwo()
    {
        // Car moving right (R) collides with car moving left (L) - both collide
        var result = _solution.CountCollisions("RL");
        Assert.Equal(2, result);
    }

    [Fact]
    public void CountCollisions_WithStationaryInMiddle_ReturnsFour()
    {
        // Cars on both sides collide with stationary car in middle
        var result = _solution.CountCollisions("RLRSLL");
        Assert.Equal(5, result);
    }

    [Fact]
    public void CountCollisions_WithNoCollisions_ReturnsZero()
    {
        // All cars moving in same direction or away from each other - no collisions
        var result = _solution.CountCollisions("LLRR");
        Assert.Equal(0, result);
    }

    [Fact]
    public void CountCollisions_WithComplexScenario_ReturnsCorrectCount()
    {
        // Example from LeetCode: "RLRSLL" should return 5
        var result = _solution.CountCollisions("RLRSLL");
        Assert.Equal(5, result);
    }

    [Fact]
    public void CountCollisions_SLL_ReturnsTwo()
    {
        // Cars on both sides collide with stationary car in middle
        var result = _solution.CountCollisions("SLL");
        Assert.Equal(2, result);
    }
    
}
