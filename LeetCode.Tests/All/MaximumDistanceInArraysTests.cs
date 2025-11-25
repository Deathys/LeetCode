using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class MaximumDistanceInArraysTests
{
    private readonly MaximumDistanceInArraysSolution _solution;

    public MaximumDistanceInArraysTests()
    {
        _solution = new MaximumDistanceInArraysSolution();
    }

    [Fact]
    public void MaxDistance_Example1_Returns4()
    {
        // Example 1: arrays = [[1,2,3],[4,5],[1,2,3]]
        // Output: 4 (pick 1 from first/third array and 5 from second array)
        var arrays = new List<IList<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5 },
            new List<int> { 1, 2, 3 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(4, result);
    }

    [Fact]
    public void MaxDistance_Example2_Returns0()
    {
        // Example 2: arrays = [[1],[1]]
        // Output: 0 (both arrays contain only 1)
        var arrays = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 1 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxDistance_TwoArraysWithLargeGap_ReturnsMaxDistance()
    {
        // arrays = [[1,4],[0,5]]
        // Max distance: 5 - 1 = 4 or 4 - 0 = 4, but best is 5 - 0 = 5
        var arrays = new List<IList<int>>
        {
            new List<int> { 1, 4 },
            new List<int> { 0, 5 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(4, result);
    }

    [Fact]
    public void MaxDistance_ThreeArraysDescending_ReturnsCorrectDistance()
    {
        // arrays = [[1,5],[3,4],[7,8]]
        // Max distance should be from different arrays
        var arrays = new List<IList<int>>
        {
            new List<int> { 1, 5 },
            new List<int> { 3, 4 },
            new List<int> { 7, 8 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(7, result);
    }

    [Fact]
    public void MaxDistance_NegativeNumbers_ReturnsCorrectDistance()
    {
        // arrays = [[-10,-5],[0,10],[-3,3]]
        // Max distance: 10 - (-10) = 20
        var arrays = new List<IList<int>>
        {
            new List<int> { -10, -5 },
            new List<int> { 0, 10 },
            new List<int> { -3, 3 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(20, result);
    }

    [Fact]
    public void MaxDistance_SingleElementArrays_ReturnsCorrectDistance()
    {
        // arrays = [[1],[5],[3]]
        // Max distance: 5 - 1 = 4
        var arrays = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 5 },
            new List<int> { 3 }
        };

        var result = _solution.MaxDistance(arrays);

        Assert.Equal(4, result);
    }
}
