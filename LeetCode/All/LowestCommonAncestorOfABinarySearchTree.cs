using System;
using System.Linq;

namespace LeetCode.All;

public class LowestCommonAncestorOfABinarySearchTree
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        if(root == null)
            return root!;

        var parentVal = root.val;

        var pVal = p.val;
        var qVal = q.val;

        if(parentVal < pVal && parentVal < qVal)
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        
        if(parentVal > pVal && parentVal > qVal)
        {
            return LowestCommonAncestor(root.left, p, q);
        }

        return root;
    }
}


public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
 
