class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        
        unordered_map<int, int> seen;
        seen.reserve(nums.size());

        for (int i = 0; i < (int)nums.size(); ++i)
        {
            if (auto iter = seen.find(target - nums[i]); iter != seen.end())
                return { iter->second, i };

            seen.insert({nums[i], i});
        }

        return {};
    }
};
