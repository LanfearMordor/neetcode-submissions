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
    public List<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();

        void InvokeOrder(TreeNode node){
            if (node == null) return;
            InvokeOrder(node.left);
            res.Add(node.val);
            InvokeOrder(node.right);
        }

        InvokeOrder(root);
        return res;
    }
}