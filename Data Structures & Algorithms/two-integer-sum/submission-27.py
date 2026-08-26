class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        L = len(nums)
        r = range
        g = ([i, j] for i in r(L) for j in r(i+1,L) if (nums[i] + nums[j]) == target)
        return next(g)
        



        
