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
    public string Tree2str(TreeNode root) {
        return root == null ? "()" : 
            root.left != null && root.right == null ? root.val + "(" + Tree2str(root.left) + ")" :
            root.left == null && root.right != null ? root.val + "()" + "(" + Tree2str(root.right) + ")" : 
            root.left == null && root.right == null ? root.val.ToString() : 
            root.val + "(" + Tree2str(root.left) + ")" + "(" + Tree2str(root.right) + ")";
    }
}