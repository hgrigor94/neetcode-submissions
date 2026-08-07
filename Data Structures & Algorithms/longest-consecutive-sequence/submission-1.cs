public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int max = 0;
        foreach (var num in set)
        {
            if (set.Contains(num-1)) continue;

            int count = 1;
            int link = num;
            while(set.Contains(++link))
            {
                count++;
            }
            max = int.Max(max, count);

        }

        return max;
    }
}
