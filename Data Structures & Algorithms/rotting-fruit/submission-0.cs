public class Solution {
    public int OrangesRotting(int[][] grid) {
            const int Fresh = 1, Rotten = 2;

            var length = grid.Length;
            var width = grid[0].Length;
            var fresh = 0;

            var rotten = new Queue<(int x, int y)>();
            for (var x = 0; x < length; x++)
            {
                for (var y = 0; y < width; y++)
                {
                    if (grid[x][y] == Rotten)
                        rotten.Enqueue((x, y));
                    else if (grid[x][y] == Fresh)
                        fresh++;
                }
            }

            var minutes = 0;
            (int dx, int dy)[] directions = [(0, 1), (0, -1), (1, 0), (-1, 0)];

            while (rotten.Count > 0 && fresh > 0)
            {
                var size = rotten.Count;

                for (var i = 0; i < size; i++)
                {
                    var current = rotten.Dequeue();

                    foreach (var direction in directions)
                    {
                        var newX = current.x + direction.dx;
                        var newY = current.y + direction.dy;


                        if (newX < 0 || newX >= length || newY < 0 || newY >= width)
                            continue;

                        if (grid[newX][newY] != 1)
                            continue;

                        rotten.Enqueue((newX, newY));
                        grid[newX][newY] = 2;
                        fresh--;
                    }
                }

                minutes++;
            }

            return fresh == 0
                ? minutes
                : -1;
    }
}
