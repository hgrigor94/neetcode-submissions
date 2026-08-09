class Solution {
public:
    bool isAnagram(string s, string t)
    {
        if (s.size() != t.size())
            return false;

        std::array<int, 26> letter_count{};

        for (char c : s)
        {
            ++letter_count[c - 'a'];            
        }

        for (char c : t)
        {
            if(--letter_count[c - 'a'] < 0)
                return false;            
        }

        return std::ranges::all_of(letter_count, [](int n) {return n == 0;});

    }
};
