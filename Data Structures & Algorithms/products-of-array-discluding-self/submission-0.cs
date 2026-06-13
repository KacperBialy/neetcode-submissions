public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var leftToRight = new int[nums.Length];
        var rightToLeft = new int[nums.Length];

        leftToRight[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
            leftToRight[i] = nums[i] * leftToRight[i - 1];

        rightToLeft[^1] = nums[^1];
        for (var i = nums.Length - 1; i > 0; i--)
            rightToLeft[i - 1] = nums[i - 1] * rightToLeft[i];

        var list = new List<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var left = 1;
            var right = 1;

            if (i > 0)
                left = leftToRight[i - 1];

            if (i + 1 < nums.Length)
                right = rightToLeft[i + 1];

            list.Add(left * right);
        }

        return list.ToArray();
    }
}
