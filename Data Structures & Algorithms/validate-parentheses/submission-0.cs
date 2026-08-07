public class Solution {
    public bool IsValid(string s)
    {
        if (s.Length < 2) return false;

        var stack = new Stack<char>(s.Length);
        stack.Push(s[0]);

        foreach(var c in s.Skip(1))
        {
            if (stack.TryPeek(out var t))
            {
                if (t == '{' && c == '}' ||
                    t == '[' && c == ']' ||
                    t == '(' && c == ')')
                {
                    stack.Pop();
                    continue;
                }
            }

            stack.Push(c);
        }

        return stack.Count == 0;
    }
}
