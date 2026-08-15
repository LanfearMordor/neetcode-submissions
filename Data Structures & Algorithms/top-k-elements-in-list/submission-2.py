class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        freq = [None] * (len(nums) + 1)

        for i in range(len(freq)):
            freq[i] = []
        
        for num in nums:
            count[num] = count.get(num,0) + 1

        for key,values in count.items():
            freq[values].append(key)
        
        res =[]

        for bucket in reversed(freq):
            for num in bucket:
                res.append(num)
                if len(res) == k:
                    return res

