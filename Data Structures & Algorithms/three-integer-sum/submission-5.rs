impl Solution {
    pub fn three_sum(mut nums: Vec<i32>) -> Vec<Vec<i32>> {
        nums.sort();
        let mut result = Vec::new();
        let n = nums.len();

        for i in 0..n {
            if i + 2 >= n { break; }                 // need at least 3 elements left
            if i > 0 && nums[i] == nums[i - 1] {
                continue;                            // skip duplicate first element
            }

            let (mut left, mut right) = (i + 1, n - 1);
            while left < right {
                let sum = nums[i] + nums[left] + nums[right];
                if sum < 0 {
                    left += 1;
                } else if sum > 0 {
                    right -= 1;
                } else {
                    result.push(vec![nums[i], nums[left], nums[right]]);
                    left += 1;
                    right -= 1;
                    while left < right && nums[left] == nums[left - 1] {
                        left += 1;   // skip dup
                    }
                    while left < right && nums[right] == nums[right + 1] {
                        right -= 1;  // skip dup
                    }
                }
            }
        }
        result
    }
}