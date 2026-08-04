class Solution {
    /**
     * @param {number[]} nums
     * @return {number[][]}
     */
    threeSum(nums) {    nums.sort((a, b) => a - b);   // numeric sort (NOT the default lexicographic!)
    const result = [];
    for (let i = 0; i < nums.length - 2; i++) {
        if (i > 0 && nums[i] === nums[i - 1]) continue;   // skip duplicate first element
        let left = i + 1, right = nums.length - 1;
        while (left < right) {
            const sum = nums[i] + nums[left] + nums[right];
            if (sum < 0) {
                left++;
            } else if (sum > 0) {
                right--;
            } else {
                result.push([nums[i], nums[left], nums[right]]);
                left++;
                right--;
                while (left < right && nums[left] === nums[left - 1]) left++;    // skip dup
                while (left < right && nums[right] === nums[right + 1]) right--;  // skip dup
            }
        }
    }
    return result;}
}
