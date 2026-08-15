public class Solution {
    


    public int TotalFruit(int[] fruits){
        int n = fruits.Length;
        int l =0;
        int ans =0;
        var dict = new Dictionary<int, int>();

        for (int r =0; r < n; r++){

            if (!dict.ContainsKey(fruits[r])){
                dict[fruits[r]] = 0;
            }
            dict[fruits[r]]++;

            while(dict.Count > 2){
                dict[fruits[l]]--;
                if(dict[fruits[l]] == 0){
                    dict.Remove(fruits[l]);
                }
                l++;
            }

            ans = Math.Max(ans, r -l +1);

        }
        return ans;
    }
}