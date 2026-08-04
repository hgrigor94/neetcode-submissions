

func threeSum(nums []int) [][]int {
    sort.Ints(nums)
    result := [][]int{}
    n := len(nums)

    for i := 0; i < n-2; i++ {
        if i > 0 && nums[i] == nums[i-1] {
            continue // skip duplicate first element
        }

        left, right := i+1, n-1
        for left < right {
            sum := nums[i] + nums[left] + nums[right]
            switch {
            case sum < 0:
                left++
            case sum > 0:
                right--
            default:
                result = append(result, []int{nums[i], nums[left], nums[right]})
                left++
                right--
                for left < right && nums[left] == nums[left-1] {
                    left++ // skip dup
                }
                for left < right && nums[right] == nums[right+1] {
                    right-- // skip dup
                }
            }
        }
    }
    return result
}