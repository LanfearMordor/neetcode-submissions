public class Solution {
    public bool IsPalindrome(string s) {
        int l =0;
        int r = s.Length -1;

        while(l<r){
            while(l<r && !IsAlphaNumeric(s[l])){
                l++;
            }
            while(r>l && !IsAlphaNumeric(s[r])){
                r--;
            }
            if (char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            l++;r--;
        }
        return true;
    }

    private bool IsAlphaNumeric(char ch){
        return((ch >='a' && ch <='z') ||
            (ch >='A' && ch <= 'Z') || (ch >='0' && ch <= '9')
            );
    }
}
