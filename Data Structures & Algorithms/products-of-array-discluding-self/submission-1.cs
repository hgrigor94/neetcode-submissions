public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var res = new int[nums.Length];
        res[0] = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            res[i] = res[i-1] * nums[i-1];
        }

        int suffix = 1;
        for (var i = nums.Length-1; i >= 0; i--)
        {
            res[i] *= suffix;
            suffix *= nums[i];
        }

        return res;
    }
}
