class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        d = {el: i for (i, el) in enumerate(nums)}
        L = len(nums)
        get = d.get
        g = ([i, j] for i in range(L) if (j := get(target - nums[i], False)) and i != j)
        return next(g)
        
