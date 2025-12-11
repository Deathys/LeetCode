using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class LongestCommonPrefixSolutionTests
{
    private readonly LongestCommonPrefixSolution _solution;

    public LongestCommonPrefixSolutionTests()
    {
        _solution = new LongestCommonPrefixSolution();
    }

    [Fact]
    public void LongestCommonPrefix_WithCommonPrefix_ReturnsPrefix()
    {
        // Arrange
        string[] strs = { "flower", "flow", "flight" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("fl", result);
    }

    [Fact]
    public void LongestCommonPrefix_WithNoCommonPrefix_ReturnsEmptyString()
    {
        // Arrange
        string[] strs = { "dog", "racecar", "car" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void LongestCommonPrefix_WithSingleString_ReturnsTheString()
    {
        // Arrange
        string[] strs = { "single" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("single", result);
    }

    [Fact]
    public void LongestCommonPrefix_WithIdenticalStrings_ReturnsTheString()
    {
        // Arrange
        string[] strs = { "test", "test", "test" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal("test", result);
    }

    [Fact]
    public void LongestCommonPrefix_WithEmptyStringInArray_ReturnsEmptyString()
    {
        // Arrange
        string[] strs = { "flower", "", "flight" };

        // Act
        var result = _solution.LongestCommonPrefix(strs);

        // Assert
        Assert.Equal(string.Empty, result);
    }
}
