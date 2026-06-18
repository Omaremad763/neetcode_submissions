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
    private int maxSum = System.Int32.MinValue;

    public int MaxPathSum(TreeNode root) {
        CalculateMaxGain(root);
        return maxSum;
    }

    private int CalculateMaxGain(TreeNode node) {
        if (node == null) return 0;

        int leftGain = System.Math.Max(CalculateMaxGain(node.left), 0);
        int rightGain = System.Math.Max(CalculateMaxGain(node.right), 0);

        int currentPathSum = node.val + leftGain + rightGain;
        
        if (currentPathSum > maxSum) {
            maxSum = currentPathSum;
        }

        return node.val + System.Math.Max(leftGain, rightGain);
    }
}