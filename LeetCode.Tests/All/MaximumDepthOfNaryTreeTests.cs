using LeetCode.All;
using Xunit;

namespace LeetCode.Tests.All;

public class MaximumDepthOfNaryTreeTests
{
    private readonly MaximumDepthOfNaryTreeSolution _solution;

    public MaximumDepthOfNaryTreeTests()
    {
        _solution = new MaximumDepthOfNaryTreeSolution();
    }

    [Fact]
    public void MaxDepth_WithThreeLevelTree_ReturnsThree()
    {
        // Tree structure:
        //       1
        //    /  |  \
        //   3   2   4
        //  / \
        // 5   6
        var node5 = new Node(5);
        var node6 = new Node(6);
        var node3 = new Node(3, new List<Node> { node5, node6 });
        var node2 = new Node(2);
        var node4 = new Node(4);
        var root = new Node(1, new List<Node> { node3, node2, node4 });

        var result = _solution.MaxDepth(root);

        Assert.Equal(3, result);
    }

    [Fact]
    public void MaxDepth_WithFiveLevelTree_ReturnsFive()
    {
        // Tree structure:
        //           1
        //      /    |    \
        //     2     3     4
        //    / \         / \
        //   5   6       8   9
        //  /           /
        // 7          10
        //           /
        //         11
        var node11 = new Node(11);
        var node10 = new Node(10, new List<Node> { node11 });
        var node7 = new Node(7);
        var node5 = new Node(5, new List<Node> { node7 });
        var node6 = new Node(6);
        var node8 = new Node(8, new List<Node> { node10 });
        var node9 = new Node(9);
        var node2 = new Node(2, new List<Node> { node5, node6 });
        var node3 = new Node(3);
        var node4 = new Node(4, new List<Node> { node8, node9 });
        var root = new Node(1, new List<Node> { node2, node3, node4 });

        var result = _solution.MaxDepth(root);

        Assert.Equal(5, result);
    }

    [Fact]
    public void MaxDepth_WithNullRoot_ReturnsZero()
    {
        // Empty tree
        Node root = null;

        var result = _solution.MaxDepth(root);

        Assert.Equal(0, result);
    }

    [Fact]
    public void MaxDepth_WithSingleNodeTree_ReturnsOne()
    {
        // Tree with only root node
        var root = new Node(1);

        var result = _solution.MaxDepth(root);

        Assert.Equal(1, result);
    }

    [Fact]
    public void MaxDepth_WithTwoLevelTreeManyChildren_ReturnsTwo()
    {
        // Tree structure:
        //       1
        //  / | | | \
        // 2  3 4 5  6
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);
        var node5 = new Node(5);
        var node6 = new Node(6);
        var root = new Node(1, new List<Node> { node2, node3, node4, node5, node6 });

        var result = _solution.MaxDepth(root);

        Assert.Equal(2, result);
    }

    [Fact]
    public void MaxDepth_WithLinearTree_ReturnsFour()
    {
        // Linear tree (each node has one child):
        // 1
        // |
        // 2
        // |
        // 3
        // |
        // 4
        var node4 = new Node(4);
        var node3 = new Node(3, new List<Node> { node4 });
        var node2 = new Node(2, new List<Node> { node3 });
        var root = new Node(1, new List<Node> { node2 });

        var result = _solution.MaxDepth(root);

        Assert.Equal(4, result);
    }
}
