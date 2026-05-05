public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var path = new List<int>();

        Dfs(0, 0);

        return result;

        void Dfs(int start, int sum)
        {
            if (sum == target)
            {
                result.Add([..path]);
                return;
            }

            for (var i = start; i < nums.Length; i++)
            {
                if (sum + nums[i] > target)
                    break;

                path.Add(nums[i]);
                Dfs(i, sum + nums[i]);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
