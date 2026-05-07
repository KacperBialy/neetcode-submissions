public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var queue = new Queue<(int x, int y)>();
        (int dx, int dy)[] directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

        var maxIslandSize = 0;
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] == 0)
                    continue;

                var islandSize = 0;
                grid[i][j] = 0;
                queue.Enqueue((i, j));

                while (queue.Count > 0)
                {
                    var (currentX, currentY) = queue.Dequeue();
                    islandSize++;
                    foreach (var (directionX, directionY) in directions)
                    {
                        var nextX = currentX + directionX;
                        var nextY = currentY + directionY;

                        if (nextX < 0 || nextX >= rows || nextY < 0 || nextY >= cols || grid[nextX][nextY] == 0)
                            continue;

                        grid[nextX][nextY] = 0;
                        queue.Enqueue((nextX, nextY));
                    }
                }

                maxIslandSize = Math.Max(maxIslandSize, islandSize);
            }
        }

        return maxIslandSize;
    }
}
