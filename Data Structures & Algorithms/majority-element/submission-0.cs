public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach(var item in nums){
            if (!dict.ContainsKey(item)){
                dict.Add(item, 1);
            }
            else{
                dict[item]++;
            }
        }

        foreach(var item in dict){
            if(item.Value > nums.Length/2){
                return item.Key;
            }
        }

        return -1;
    }
}