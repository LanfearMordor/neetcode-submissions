public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var count  = new Dictionary<int,int>();
        var freq = new List<int>[nums.Length + 1];

        for(int  i =0; i < freq.Length ; i++){
            freq[i] = new List<int>();
        }

        foreach(var item in nums){
            if (count.ContainsKey(item)){
                count[item]++;
            }
            else{
                count[item] =1;
            }
        }

        foreach( var entry in count){
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(int j = freq.Length-1; index < k && j > 0 ; j--){
            foreach(int n in freq[j]){
                res[index] = n;
                index++;

                if (index == k)
                    return res;
            }
        }
        return res;

    }
}
