using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class LowestCommonAncestorOfABinarySearchTreeTests
{
    [Fact]
    public void Test_Example1_LCA_Is_6()
    {
        // Arrange
        //       6
        //      / \
        //     2   8
        //    / \ / \
        //   0  4 7  9
        //     / \
        //    3   5
        var root = new TreeNode(6)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(0),
                right = new TreeNode(4)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(5)
                }
            },
            right = new TreeNode(8)
            {
                left = new TreeNode(7),
                right = new TreeNode(9)
            }
        };

        var p = root.left; // node 2
        var q = root.right; // node 8
        var solution = new LowestCommonAncestorOfABinarySearchTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(6, result.val);
    }

    [Fact]
    public void Test_Example2_LCA_Is_2()
    {
        // Arrange
        //       6
        //      / \
        //     2   8
        //    / \ / \
        //   0  4 7  9
        //     / \
        //    3   5
        var root = new TreeNode(6)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(0),
                right = new TreeNode(4)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(5)
                }
            },
            right = new TreeNode(8)
            {
                left = new TreeNode(7),
                right = new TreeNode(9)
            }
        };

        var p = root.left; // node 2
        var q = root.left.right; // node 4
        var solution = new LowestCommonAncestorOfABinarySearchTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(2, result.val);
    }

    [Fact]
    public void Test_TwoNodes_LeftSubtree()
    {
        // Arrange
        //       6
        //      / \
        //     2   8
        //    / \
        //   0  4
        var root = new TreeNode(6)
        {
            left = new TreeNode(2)
            {
                left = new TreeNode(0),
                right = new TreeNode(4)
            },
            right = new TreeNode(8)
        };

        var p = root.left.left; // node 0
        var q = root.left.right; // node 4
        var solution = new LowestCommonAncestorOfABinarySearchTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(2, result.val);
    }

    [Fact]
    public void Test_TwoNodes_RightSubtree()
    {
        // Arrange
        //       6
        //      / \
        //     2   8
        //        / \
        //       7   9
        var root = new TreeNode(6)
        {
            left = new TreeNode(2),
            right = new TreeNode(8)
            {
                left = new TreeNode(7),
                right = new TreeNode(9)
            }
        };

        var p = root.right.left; // node 7
        var q = root.right.right; // node 9
        var solution = new LowestCommonAncestorOfABinarySearchTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(8, result.val);
    }

    [Fact]
    public void Test_OneNodeIsRoot()
    {
        // Arrange
        //       6
        //      / \
        //     2   8
        var root = new TreeNode(6)
        {
            left = new TreeNode(2),
            right = new TreeNode(8)
        };

        var p = root; // node 6
        var q = root.left; // node 2
        var solution = new LowestCommonAncestorOfABinarySearchTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(6, result.val);
    }
}
