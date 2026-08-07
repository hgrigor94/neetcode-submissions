public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int max = 0;
        foreach (var num in set)
        {
            if (set.Contains(num-1)) continue;

            int len = 1;
            while(set.Contains(num + len))
            {
                len++;
            }
            max = Math.Max(max, len);

        }

        return max;
    }
}
