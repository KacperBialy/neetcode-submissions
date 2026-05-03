public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var leftIndex = 0;
        var rightIndex = numbers.Length - 1;

        while (rightIndex >= leftIndex)
        {
            var sum = numbers[leftIndex] + numbers[rightIndex];
            if (sum == target)
                return [leftIndex + 1, rightIndex + 1];

            if (sum > target)
                rightIndex--;
            else
                leftIndex++;
        }

        return [];
    }
}
