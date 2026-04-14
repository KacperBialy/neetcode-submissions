/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsBalanced(TreeNode root)
    {
        return GetValidHeight(root) != -1;
    }

    int GetValidHeight(TreeNode root)
    {
        if (root == null)
            return 0;

        var left = GetValidHeight(root.left);
        var right = GetValidHeight(root.right);
        if (left == -1 || right == -1 || Math.Abs(left - right) > 1)
            return -1;

        return 1 + Math.Max(left, right);
    }
}
