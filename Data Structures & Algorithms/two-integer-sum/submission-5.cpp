class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        
        unordered_map<int, int> map_el_idx;
        map_el_idx.reserve(nums.size());

        for (int i = 0; int num : nums)
        {
            if (map_el_idx.count(target - num))
            {
                return { map_el_idx[target - num], i };
            }

            map_el_idx.insert({num, i});
            ++i;
        }

        return {};
    }
};
