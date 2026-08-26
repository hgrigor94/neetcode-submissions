class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        L = len(nums)
        g = ([i, j] for i in range(L) for j in range(L) if (nums[i] + nums[j]) == target and i != j)
        return next(g)
        



        
