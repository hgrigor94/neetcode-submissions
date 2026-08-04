public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        var table = new int[26];

        foreach (var el in s)
            table[(int)el - (int)'a']++;

        foreach (var el in t)
            table[(int)el - (int)'a']--;

        return table.All(el => el == 0);
    }
}
