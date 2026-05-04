public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>> { new() };

        foreach (var num in nums)
        {
            var size = result.Count;
            for (var i = 0; i < size; i++)
                result.Add([..result[i], num]);
        }

        return result;
    }
}
