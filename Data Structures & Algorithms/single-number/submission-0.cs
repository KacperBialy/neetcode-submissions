public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.Aggregate(0, (current, num) => current ^ num); 
    }
}
