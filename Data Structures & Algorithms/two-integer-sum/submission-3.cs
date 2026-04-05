public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbersMap = new();

        for (var i = 0; i < nums.Length; i++)
        {
            var lookingFor = target - nums[i];

            if(numbersMap.ContainsKey(lookingFor))
                return new int[] { numbersMap[lookingFor], i };

            if(!numbersMap.TryAdd(nums[i], i))
                numbersMap[nums[i]] = i;
        }

        return Enumerable.Empty<int>().ToArray();
    }
}
