public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var threeSum = new List<List<int>>();

        for (var index = 0; index < nums.Length; index++)
        {
            var left = index + 1;
            var right = nums.Length - 1;

            var currentValue = nums[index];

            if (index > 0 && nums[index - 1] == nums[index])
                continue;

            while (right > left)
            {
                var leftValue = nums[left];
                var rightValue = nums[right];

                switch (currentValue + leftValue + rightValue)
                {
                    case < 0:
                        left++;
                        break;
                    case > 0:
                        right--;
                        break;
                    default:
                    {
                        threeSum.Add([currentValue, leftValue, rightValue]);
                        left++;
                        while (right > left && nums[left] == nums[left - 1])
                            left++;
                        break;
                    }
                }
            }
        }

        return threeSum;
    }
}
