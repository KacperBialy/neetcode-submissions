public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var threeSum = new List<List<int>>();

        var lastValue = int.MinValue;
        for (var index = 0; index < nums.Length; index++)
        {
            var left = index + 1;
            var right = nums.Length - 1;

            var currentValue = nums[index];

            if (currentValue == lastValue)
                continue;

            lastValue = currentValue;

            while (right > left)
            {
                var leftValue = nums[left];
                var rightValue = nums[right];
                if (currentValue + leftValue + rightValue == 0)
                {
                    threeSum.Add([currentValue, leftValue, rightValue]);
                    left++;
                    while (right > left && nums[left] == nums[left - 1])
                        left++;
                }
                else if (leftValue + rightValue < -currentValue)
                    left++;
                else
                    right--;
            }
        }

        return threeSum;
    }
}
