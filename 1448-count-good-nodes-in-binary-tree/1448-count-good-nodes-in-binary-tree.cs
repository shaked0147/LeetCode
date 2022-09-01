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
    
    int count = 0;
    
    public int GoodNodes(TreeNode root) {
        FindCountGoodNodes(root, root.val);
        return count;
    }
    
    private void FindCountGoodNodes(TreeNode node, int largest){
        if(node == null)
            return;
        
        if(node.val >= largest){
            largest = node.val;
            count++;
        }
        
        FindCountGoodNodes(node.left, largest);
        FindCountGoodNodes(node.right, largest);
    }
}