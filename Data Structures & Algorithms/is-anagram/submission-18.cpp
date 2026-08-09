class Solution {
public:
    bool isAnagram(string s, string t)
    {
        std::array<int, 26> letter_count {0};

        for (char c : s)
        {
            ++letter_count[c - 'a'];            
        }

        for (char c : t)
        {
            --letter_count[c - 'a'];            
        }

        return std::ranges::all_of(letter_count, [](int n) {return n == 0;});

    }
};
