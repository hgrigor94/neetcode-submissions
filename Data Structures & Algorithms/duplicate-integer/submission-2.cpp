class Solution {
public:
    bool hasDuplicate(vector<int>& nums) {
//        std::unordered_set<int> my_set(nums.begin(), nums.end());
//        return my_set.size() != nums.size();
        auto initial_size = nums.size();
        std::sort(nums.begin(), nums.end());
        nums.erase(std::unique(nums.begin(), nums.end()), nums.end());
        return initial_size != nums.size();
        
    }
};