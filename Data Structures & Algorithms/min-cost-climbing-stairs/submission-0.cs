public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var length = cost.Length;
        var minCost = new int[length + 2];
        for (var i = length - 1; i >= 0; i--)
        {
            minCost[i] = cost[i] + Math.Min(minCost[i + 1], minCost[i + 2]);
        }

        return Math.Min(minCost[0], minCost[1]);
    }
}
