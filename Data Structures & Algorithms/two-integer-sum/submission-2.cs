public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var tb = new Dictionary<int, int>(nums.Length);

        foreach (var (i, el) in nums.Index())
        {
            if (tb.ContainsKey(target - el))
            {
                return [tb[target - el], i];
            }

            tb.TryAdd(el, i);
        }

        return [];
    }
}
