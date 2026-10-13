public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dict = new Dictionary<int, int>();

        for (int i =0; i<= nums.Length -1; i++){
            int diff = target - nums[i];

            if (dict.ContainsKey(diff)){
                return new int[]{dict[diff], i};
            }
            else{
                dict[nums[i]] = i;
            }
        }
        return new int[]{};


    }
}
