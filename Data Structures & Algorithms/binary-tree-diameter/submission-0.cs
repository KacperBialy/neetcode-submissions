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
    public int DiameterOfBinaryTree(TreeNode root) {
        var result = 0;

        int Depth(TreeNode node)
        {
            if (node == null)
                return 0;

            var left = Depth(node.left);
            var right = Depth(node.right);
            result = Math.Max(result, left + right);

            return 1 + Math.Max(left, right);
        }

        Depth(root);
        return result;
    }
}
