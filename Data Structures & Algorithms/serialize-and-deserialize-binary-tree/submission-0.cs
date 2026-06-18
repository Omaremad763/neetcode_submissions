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

public class Codec {
    public string Serialize(TreeNode root) {
        if (root == null) return "";

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.Collections.Generic.Queue<TreeNode> queue = new System.Collections.Generic.Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            TreeNode curr = queue.Dequeue();
            if (curr == null) {
                sb.Append("null,");
                continue;
            }

            sb.Append(curr.val).Append(",");
            queue.Enqueue(curr.left);
            queue.Enqueue(curr.right);
        }

        return sb.ToString();
    }

    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;

        string[] values = data.Split(',');
        TreeNode root = new TreeNode(System.Convert.ToInt32(values[0]));
        
        System.Collections.Generic.Queue<TreeNode> queue = new System.Collections.Generic.Queue<TreeNode>();
        queue.Enqueue(root);
        
        int i = 1;
        while (queue.Count > 0 && i < values.Length) {
            TreeNode parent = queue.Dequeue();

            if (values[i] != "null" && !string.IsNullOrEmpty(values[i])) {
                TreeNode left = new TreeNode(System.Convert.ToInt32(values[i]));
                parent.left = left;
                queue.Enqueue(left);
            }
            i++;

            if (i < values.Length && values[i] != "null" && !string.IsNullOrEmpty(values[i])) {
                TreeNode right = new TreeNode(System.Convert.ToInt32(values[i]));
                parent.right = right;
                queue.Enqueue(right);
            }
            i++;
        }

        return root;
    }
}
