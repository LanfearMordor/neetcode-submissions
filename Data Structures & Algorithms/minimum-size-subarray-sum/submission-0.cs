public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int l= 0, total = 0;
        int res = int.MaxValue;

        for (int r =0; r< nums.Length; r++){
            total += nums[r];

            while(total >= target)
            {
                res = Math.Min(r-l+1, res);
                total -= nums[l];
                l++;

            }
        }
        return res == int.MaxValue ? 0:res;
    }
}