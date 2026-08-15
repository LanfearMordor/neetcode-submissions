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

// the genral ides is to check if the immediate next node is greater than the previos node or not. 
//If yes, we knowits a good node.
// take the roo.val as the initial max(since this is the first value we have ) and then upadte the max value on each itenation based on the next node val.
public class Solution {
    
    public int GoodNodes(TreeNode root) {
        int dfs(TreeNode node, int maxVal){
            //int res = 0;
            if (node == null) return 0;
            var res = (node.val >= maxVal)? 1:0;
            maxVal = Math.Max(maxVal, node.val);
            res+= dfs(node.left, maxVal);
            res+= dfs(node.right, maxVal);
            return res;
        }

        var outP = dfs(root, root.val);
        return outP;
    }
}
