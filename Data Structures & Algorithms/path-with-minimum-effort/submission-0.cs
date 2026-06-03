public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        var rows = heights.Length;
        var cols = heights[0].Length;
        var visited = new HashSet<(int, int)>();

        var priorityQueue = new PriorityQueue<(int row, int col), int>();
        priorityQueue.Enqueue((0, 0), 0);

        while (priorityQueue.TryDequeue(out var node, out var effort))
        {
            if (node.row == rows - 1 && node.col == cols - 1)
                return effort;

            if (!visited.Add(node))
                continue;

            foreach (var (dr, dc) in new[] { (0, 1), (0, -1), (1, 0), (-1, 0) })
            {
                var nextRow = node.row + dr;
                var nextCol = node.col + dc;
                if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
                    continue;
                if (visited.Contains((nextRow, nextCol)))
                    continue;

                var nextEffort = Math.Max(effort, Math.Abs(heights[nextRow][nextCol] - heights[node.row][node.col]));
                priorityQueue.Enqueue((nextRow, nextCol), nextEffort);
            }
        }

        return 0;
    }
}