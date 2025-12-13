using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class LRUCacheTests
{
    [Fact]
    public void Get_WithExistingKey_ReturnsCorrectValue()
    {
        // Arrange
        var cache = new LRUCache(2);
        cache.Put(1, 100);
        cache.Put(2, 200);

        // Act
        var result1 = cache.Get(1);
        var result2 = cache.Get(2);

        // Assert
        Assert.Equal(100, result1);
        Assert.Equal(200, result2);
    }

    [Fact]
    public void Get_WithNonExistingKey_ReturnsMinusOne()
    {
        // Arrange
        var cache = new LRUCache(2);
        cache.Put(1, 100);

        // Act
        var result = cache.Get(2);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Constructor_WithInvalidCapacity_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new LRUCache(0));
        Assert.Throws<ArgumentException>(() => new LRUCache(-1));
        Assert.Throws<ArgumentException>(() => new LRUCache(3001));
    }

    [Fact]
    public void Put_WithMultipleOperations_UpdatesExistingKeys()
    {
        // Arrange
        var cache = new LRUCache(2);
        cache.Put(1, 100);
        cache.Put(2, 200);

        // Act
        cache.Put(1, 150); // Update existing key
        var result = cache.Get(1);

        // Assert
        Assert.Equal(150, result);
    }

    [Fact]
    public void LRUCache_Example1_EvictsLeastRecentlyUsedKey()
    {
        // Arrange
        var cache = new LRUCache(2);

        // Act & Assert
        cache.Put(1, 1); // cache is {1=1}
        cache.Put(2, 2); // cache is {1=1, 2=2}
        Assert.Equal(1, cache.Get(1)); // return 1

        cache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        Assert.Equal(-1, cache.Get(2)); // returns -1 (not found)

        cache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        Assert.Equal(-1, cache.Get(1)); // return -1 (not found)
        Assert.Equal(3, cache.Get(3)); // return 3
        Assert.Equal(4, cache.Get(4)); // return 4
    }
}
