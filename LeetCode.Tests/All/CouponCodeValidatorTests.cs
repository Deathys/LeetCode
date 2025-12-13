using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class CouponCodeValidatorTests
{
    private readonly CouponCodeValidator _validator;

    public CouponCodeValidatorTests()
    {
        _validator = new CouponCodeValidator();
    }

    [Fact]
    public void ValidateCoupons_WithAllValidCoupons_ReturnsAllCodes()
    {
        // Arrange
        string[] codes = { "SAVE20", "DEAL30", "OFF50" };
        string[] businessLines = { "grocery", "electronics", "pharmacy" };
        bool[] isActive = { true, true, true };

        // Act
        var result = _validator.ValidateCoupons(codes, businessLines, isActive);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Contains("SAVE20", result);
        Assert.Contains("DEAL30", result);
        Assert.Contains("OFF50", result);
    }

    [Fact]
    public void ValidateCoupons_WithInactiveCoupons_FiltersInactiveCoupons()
    {
        // Arrange
        string[] codes = { "SAVE20", "DEAL30", "OFF50" };
        string[] businessLines = { "grocery", "electronics", "pharmacy" };
        bool[] isActive = { true, false, true };

        // Act
        var result = _validator.ValidateCoupons(codes, businessLines, isActive);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains("SAVE20", result);
        Assert.DoesNotContain("DEAL30", result);
        Assert.Contains("OFF50", result);
    }

    [Fact]
    public void ValidateCoupons_WithInvalidBusinessLine_FiltersInvalidBusinessLines()
    {
        // Arrange
        string[] codes = { "SAVE20", "DEAL30", "OFF50" };
        string[] businessLines = { "grocery", "invalid", "pharmacy" };
        bool[] isActive = { true, true, true };

        // Act
        var result = _validator.ValidateCoupons(codes, businessLines, isActive);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains("SAVE20", result);
        Assert.DoesNotContain("DEAL30", result);
        Assert.Contains("OFF50", result);
    }

    [Fact]
    public void ValidateCoupons_WithSpecialCharactersInCode_FiltersInvalidCodes()
    {
        // Arrange
        string[] codes = { "SAVE20", "DEAL-30", "OFF@50", "VALID123" };
        string[] businessLines = { "grocery", "electronics", "pharmacy", "restaurant" };
        bool[] isActive = { true, true, true, true };

        // Act
        var result = _validator.ValidateCoupons(codes, businessLines, isActive);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains("SAVE20", result);
        Assert.DoesNotContain("DEAL-30", result);
        Assert.DoesNotContain("OFF@50", result);
        Assert.Contains("VALID123", result);
    }
}
