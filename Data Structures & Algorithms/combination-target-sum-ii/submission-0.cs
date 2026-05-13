public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
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

            for (var i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                if (sum + candidates[i] > target)
                    break;

                path.Add(candidates[i]);
                Dfs(i + 1, sum + candidates[i]);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
