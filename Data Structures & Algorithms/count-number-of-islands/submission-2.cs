public class Solution {
    public int NumIslands(char[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;

        var stack = new Stack<(int x, int y)>();

        (int dx, int dy)[] directions = [(-1, 0), (1, 0), (0, -1), (0, 1)];

        var count = 0;
        for (var x = 0; x < rows; x++)
        {
            for (var y = 0; y < cols; y++)
            {
                if (grid[x][y] != '1')
                    continue;

                count++;
                grid[x][y] = '0';
                stack.Push((x, y));

                while (stack.Count > 0)
                {
                    var (cx, cy) = stack.Pop();
                    foreach (var (dx, dy) in directions)
                    {
                        var nx = cx + dx;
                        var ny = cy + dy;
                        if (nx < 0 || nx >= rows || ny < 0 || ny >= cols || grid[nx][ny] != '1')
                            continue;
                        grid[nx][ny] = '0';
                        stack.Push((nx, ny));
                    }
                }
            }
        }

        return count;
    }
}
