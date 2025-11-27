using System;
using System.Collections;

namespace LeetCode.All;

public class MaximumDepthOfNaryTreeSolution
{
    public int MaxDepth(Node root) 
    {
        if(root == null)
            return 0;

        if(root.children == null)
            return 1;

        Queue<(Node, int)> queue = new Queue<(Node, int)>();

        queue.Enqueue((root, 1));
        int maxDepth = 0;

        while(queue.Count > 0)
        {
            (var current, var currentDepth) = queue.Dequeue();
            maxDepth = Math.Max(maxDepth, currentDepth);
            
            if(current.children == null)
                continue;

            foreach(var child in current.children)
            {
                queue.Enqueue((child, currentDepth + 1));
            }
        }
        
        return maxDepth;
    }
}

public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}