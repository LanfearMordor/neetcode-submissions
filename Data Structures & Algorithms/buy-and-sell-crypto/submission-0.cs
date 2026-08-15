public class Solution {
    public int MaxProfit(int[] prices) {
        int l =0;
        int r =1;
        int maxP =0;

        while(r < prices.Length){
            if(prices[l] < prices[r]){
                int p = prices[r] - prices[l];
                maxP = Math.Max(maxP, p);
            }
            else{
                l =r; //new cheapest found
            }
            r++;
        }
        return maxP;
    }
}
