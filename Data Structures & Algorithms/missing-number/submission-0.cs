public class Solution {
    public int MissingNumber(int[] nums) {
        var result = nums.Length;
        for (var i = 0; i < nums.Length; i++)
            result ^= i ^ nums[i];

        return result;
    }
}
