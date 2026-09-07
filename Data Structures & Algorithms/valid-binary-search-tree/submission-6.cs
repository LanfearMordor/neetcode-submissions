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
// In a BST, in-order traversal (left → node → right) visits nodes in ascending sorted order if and only if the tree is a valid BST.


public class Solution {
    public bool IsValidBST(TreeNode root) {
        var res = new List<int>();

        void InOrder(TreeNode node){
            if (node == null) return;
            InOrder(node.left);
            res.Add(node.val);
            InOrder(node.right);
        }

        InOrder(root);

        for (int i=0; i<res.Count -1;i++){
            if (res[i]<res[i+1]){
                continue;
            }
            else{
                return false;
            }
                
            
        }

        return true;
    }
}
