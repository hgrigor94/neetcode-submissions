public class Solution {
public List<List<int>> ThreeSum(int[] nums) {
    Array.Sort(nums);
    var result = new List<List<int>>();
    for (int i = 0; i < nums.Length - 2; i++) {
        if (i > 0 && nums[i] == nums[i - 1]) continue;   // skip duplicate first element
        int left = i + 1, right = nums.Length - 1;
        while (left < right) {
            int sum = nums[i] + nums[left] + nums[right];
            if (sum < 0) {
                left++;
            } else if (sum > 0) {
                right--;
            } else {
                result.Add(new List<int> { nums[i], nums[left], nums[right] });
                left++;
                right--;
                while (left < right && nums[left] == nums[left - 1]) left++;    // skip dup
                while (left < right && nums[right] == nums[right + 1]) right--;  // skip dup
            }
        }
    }
    return result;
}
}
