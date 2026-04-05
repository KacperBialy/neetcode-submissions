public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, List<int>> numbersMap = new();

        for (var i = 1; i < nums.Length; i++)
        {
            var added = numbersMap.TryAdd(nums[i], new List<int> { i });

            if (!added)
                numbersMap[nums[i]].Add(i);
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var lookingFor = target - nums[i];
            if (numbersMap.TryGetValue(lookingFor, out var indexes))
            {
                var index = indexes.FirstOrDefault(index => index != i);

                if (index == default)
                    continue;

                return new int[] { i, index };
            }
        }

        return Enumerable.Empty<int>().ToArray();
    }
}
