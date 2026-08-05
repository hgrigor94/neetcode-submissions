public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>(strs.Length);

        foreach(var word in strs)
        {
            var arr = word.ToCharArray();
            Array.Sort(arr);
            var key = new String(arr);

            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string> {word};
            }
            else
            {
                dict[key].Add(word);
            }
        } 

        return new List<List<string>>(dict.Values);
    }
}
