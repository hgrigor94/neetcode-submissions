public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);
        return nums.Any(el => !set.Add(el));
    }
}