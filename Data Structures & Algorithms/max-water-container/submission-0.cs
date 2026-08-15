public class Solution {
    public int MaxArea(int[] heights) {
         int n = heights.Length ;
         int res =0;
         for ( int i =0; i<n; i++){
            for (int j= i+1 ; j<n; j++){
                res = Math.Max(res, Math.Min(heights[i], heights[j]) * (j-i));

            }
         }
         return res;
    }
}
