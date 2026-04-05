public class Solution {
    public int Search(int[] nums, int target) {
    var result = Array.BinarySearch(nums, target);

    if (result < 0)
        return -1;

    return result;
    }
}
