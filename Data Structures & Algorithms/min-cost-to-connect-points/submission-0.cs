public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        var queue = new PriorityQueue<int, int>();
        queue.Enqueue(0, 0);

        var sum = 0;
        var visited = new HashSet<int>();
        while (visited.Count < points.Length && queue.TryDequeue(out var point, out var cost))
        {
            if(!visited.Add(point))
                continue;

            sum += cost;

            for (var i = 0; i < points.Length; i++)
            {
                if (visited.Contains(i))
                    continue;

                var manhattanDistance = Math.Abs(points[point][0] - points[i][0]) + Math.Abs(points[point][1] - points[i][1]);
                queue.Enqueue(i, manhattanDistance);
            }

        }

        return sum;
    }
}
