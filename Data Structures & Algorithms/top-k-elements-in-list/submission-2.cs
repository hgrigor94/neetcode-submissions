
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>(int.Min(2001, nums.Length));

        foreach (var el in nums)
        {       
        ref int count = ref System.Runtime.InteropServices.CollectionsMarshal.GetValueRefOrAddDefault(dict, el, out _);
        count ++;
        }

        return dict.OrderByDescending(kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToArray();
    }
}
