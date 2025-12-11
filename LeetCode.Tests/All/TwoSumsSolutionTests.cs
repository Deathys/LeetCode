using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class TwoSumsSolutionTests
{
    private readonly TwoSumsSolution _solution;

    public TwoSumsSolutionTests()
    {
        _solution = new TwoSumsSolution();
    }

    [Fact]
    public void TwoSum_WithStandardCase_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Act
        var result = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_WithMultiplePairs_ReturnsFirstValidPair()
    {
        // Arrange
        int[] nums = { 3, 2, 4 };
        int target = 6;

        // Act
        var result = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void TwoSum_WithDuplicateNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { 3, 3 };
        int target = 6;

        // Act
        var result = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_WithNegativeNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = { -1, -2, -3, -4, -5 };
        int target = -8;

        // Act
        var result = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 2, 4 }, result);
    }

    [Fact]
    public void TwoSum_WithNoSolution_ThrowsException()
    {
        // Arrange
        int[] nums = { 1, 2, 3 };
        int target = 10;

        // Act & Assert
        Assert.Throws<Exception>(() => _solution.TwoSum(nums, target));
    }
}
