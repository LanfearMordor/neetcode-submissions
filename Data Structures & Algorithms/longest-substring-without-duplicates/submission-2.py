class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:

        last_seen ={}
        max_length = 0
        left = 0

        for right in range(len(s)):
            if s[right] in last_seen:
                left = max(left, last_seen[s[right]] + 1)
            

            last_seen[s[right]] = right
            max_length = max(max_length, right - left + 1)
        
        return max_length
        