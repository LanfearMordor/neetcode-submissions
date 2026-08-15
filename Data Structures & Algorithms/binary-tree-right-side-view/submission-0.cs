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
    public List<int> RightSideView(TreeNode root) {
        
        var res = new List<int>();
        if (root == null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            TreeNode rightSide = null;
            int qLen = q.Count;

            for(int i =0; i < qLen; i++){
                var node = q.Dequeue();
                if(node != null){
                    rightSide = node;
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if (rightSide != null){
                res.Add(rightSide.val);
            }


        }
        return res;
    }
}
