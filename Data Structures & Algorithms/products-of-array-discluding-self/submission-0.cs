public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefProd = new List<int>(nums.Length + 1) {1};
        var suffProd = new List<int>(nums.Length + 1) {1};

        foreach (var el in nums)
        {
            prefProd.Add(prefProd[^1] * el);
        }

        foreach (var el in nums.Reverse())
        {
            suffProd.Add(suffProd[^1] * el);
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = (prefProd[i] * suffProd[^(i+2)]);
        }

        return result;
    }
}
