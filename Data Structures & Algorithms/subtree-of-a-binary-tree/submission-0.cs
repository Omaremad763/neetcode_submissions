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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        System.Text.StringBuilder sbRoot = new System.Text.StringBuilder();
        System.Text.StringBuilder sbSub = new System.Text.StringBuilder();
        
        Serialize(root, sbRoot);
        Serialize(subRoot, sbSub);
        
        return sbRoot.ToString().Contains(sbSub.ToString());
    }

    private void Serialize(TreeNode node, System.Text.StringBuilder sb) {
        if (node == null) {
            sb.Append(",#");
            return;
        }
        sb.Append(",").Append(node.val);
        Serialize(node.left, sb);
        Serialize(node.right, sb);
    }
}
