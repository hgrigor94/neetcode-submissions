public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        var table = new int[26];

        foreach (var el in s)
            table[el - 'a']++;

        foreach (var el in t)
            table[el - 'a']--;

        return table.All(el => el == 0);
    }
}
