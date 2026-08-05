
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

        var pq = new PriorityQueue<int, int>(k);

        foreach (var (val, freq) in dict)
        {
            pq.Enqueue(val, freq);
            if (pq.Count > k)
                pq.Dequeue();
        }

        var result = new int[k];
        for(var i = 0; i < k; i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
