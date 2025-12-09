using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class PalindromeNumberTests
{
    private readonly PalindromeNumber _solution;

    public PalindromeNumberTests()
    {
        _solution = new PalindromeNumber();
    }

    [Fact]
    public void IsPalindrome_WithPositivePalindrome_ReturnsTrue()
    {
        // 121 is a palindrome
        var result = _solution.IsPalindrome(121);
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_WithNegativeNumber_ReturnsFalse()
    {
        // Negative numbers are not palindromes (e.g., -121 reads as 121- from right to left)
        var result = _solution.IsPalindrome(-121);
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
    {
        // 123 is not a palindrome
        var result = _solution.IsPalindrome(123);
        Assert.False(result);
    }

    [Fact]
    public void IsPalindrome_WithSingleDigit_ReturnsTrue()
    {
        // Single digit numbers are palindromes
        var result = _solution.IsPalindrome(7);
        Assert.True(result);
    }
}
