public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var table = new Dictionary<int, bool>(nums.Length);
        foreach (var el in nums)
        {
            if (!table.TryAdd(el, true))
                return true;
        }

        return false;

    }
}