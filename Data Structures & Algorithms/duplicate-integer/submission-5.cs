public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        foreach(var el in nums)
        {
            if (!set.Add(el))
            {
                return true;
            }
        }

        return false;
    }
}