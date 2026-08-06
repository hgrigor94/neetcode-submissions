public class Solution {

    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return String.Empty;

        var builder = new StringBuilder(16 * strs.Count);
        foreach ( var word in strs)
        {
            int controlLength = word.Length < 10  ? 1 :
                                word.Length < 100 ? 2 : 3;

            builder.Append(controlLength);
            builder.Append(word.Length);
            builder.Append(word);
        }

        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        if (string.IsNullOrEmpty(s)) return [];

        var strList = new List<string>(s.Length / 16);
        ReadOnlySpan<char> view = s.AsSpan();
        int i = 0;
        while(i < s.Length - 1)
        {
            int controlLength = s[i] - '0';
            int wordLength = int.Parse(view.Slice(i + 1, controlLength));
            strList.Add(view.Slice(i+ 1 + controlLength, wordLength).ToString());
            i += controlLength + wordLength + 1;
        }

        return strList;
   }
}
