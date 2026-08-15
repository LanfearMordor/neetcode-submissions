public class Solution {
    public int TotalFruit(int[] fruits) {
        int n = fruits.Length;
        int res = 0;

        for (int i =0; i<n; i++){
            var set = new HashSet<int>();
            for (int j=i; j<n; j++){
                set.Add(fruits[j]);

                if (set.Count > 2)
                    break;

                res = Math.Max(res, j-i+1);
            }
        }
        return res;
    }
}