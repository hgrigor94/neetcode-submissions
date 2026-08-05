
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

        var buckets = new List<int>[nums.Length + 1];
        foreach (var (val, freq) in dict)
        {
            if (buckets[freq] is null)
            {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(val);
        }

        var result = new int[k];
        var i = 0;
        foreach (var bucket in buckets.Reverse().Where(b => b is not null))
        {
            foreach (var el in bucket)
            {
                if (i == k ) return result;
                result[i++] = el;
            }
        }
        return result;
    }
}
