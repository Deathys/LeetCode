using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class LowestCommonAncestorOfABinaryTreeTests
{
    [Fact]
    public void Test_Example1_LCA_Is_3()
    {
        // Arrange
        //       3
        //      / \
        //     5   1
        //    / \ / \
        //   6  2 0  8
        //     / \
        //    7   4
        var root = new TreeNode(3)
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            },
            right = new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(8)
            }
        };

        var p = root.left; // node 5
        var q = root.right; // node 1
        var solution = new LowestCommonAncestorOfABinaryTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(3, result.val);
    }

    [Fact]
    public void Test_Example2_LCA_Is_5()
    {
        // Arrange
        //       3
        //      / \
        //     5   1
        //    / \ / \
        //   6  2 0  8
        //     / \
        //    7   4
        var root = new TreeNode(3)
        {
            left = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            },
            right = new TreeNode(1)
            {
                left = new TreeNode(0),
                right = new TreeNode(8)
            }
        };

        var p = root.left; // node 5
        var q = root.left.right.right; // node 4
        var solution = new LowestCommonAncestorOfABinaryTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(5, result.val);
    }

    [Fact]
    public void Test_TwoNodes_OneIsRoot()
    {
        // Arrange
        //       1
        //      /
        //     2
        var root = new TreeNode(1)
        {
            left = new TreeNode(2)
        };

        var p = root; // node 1
        var q = root.left; // node 2
        var solution = new LowestCommonAncestorOfABinaryTree();

        // Act
        var result = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(1, result.val);
    }
}
