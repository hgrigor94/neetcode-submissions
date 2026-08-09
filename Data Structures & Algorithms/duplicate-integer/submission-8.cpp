class Solution {
public:
    bool hasDuplicate(vector<int>& nums)
    {
        std::unordered_set<int> mySet(nums.size());

        for (const auto& num: nums)
        {
            auto [iter, success] =  mySet.insert(num);
            std::cout << success << "\n";
            if (!success)
            {
                return true;
            }

        }
        return false;
    }
};