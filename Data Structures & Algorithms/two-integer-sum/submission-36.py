class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        d = {el: i for (i, el) in enumerate(nums)}
        return next([i, j] for i in range(len(nums)) if (j := d.get(target - nums[i])) is not None and i != j)
        
