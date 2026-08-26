class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        seen = {i:1 for i in nums}
        return len(nums) != len(seen)

