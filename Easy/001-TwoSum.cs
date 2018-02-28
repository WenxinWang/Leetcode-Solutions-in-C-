// may not use the same element twice + each input has only one solution

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = nums.Length-1; j > i; j--)
            {
                var result = nums[i] + nums[j];
                if ( result == target)
                {
                    return new int[]{i,j};
                }
            }
        }
        return new int[]{};
    }
}
