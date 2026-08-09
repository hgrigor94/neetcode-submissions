class Solution {
public:
    bool hasDuplicate(vector<int>& nums)
    {
        std::unordered_set<int> mySet;
        mySet.reserve(nums.size());

        for (int num: nums)
        {
            if(!mySet.insert(num).second)
                return true;
        }
        return false;
    }
};