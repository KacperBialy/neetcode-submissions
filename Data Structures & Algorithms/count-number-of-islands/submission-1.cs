public class Solution {
    public int NumIslands(char[][] grid) {
            Dictionary<(int x, int y), List<(int x, int y)>> map = new();

            for (var x = 0; x < grid.Length; x++)
            {
                for (var y = 0; y < grid[0].Length; y++)
                {
                    if (grid[x][y] == '0')
                        continue;

                    var neighbors = new List<(int x, int y)>();

                    if (x - 1 >= 0 && grid[x - 1][y] == '1')
                        neighbors.Add((x - 1, y));
                    if (x + 1 < grid.Length && grid[x + 1][y] == '1')
                        neighbors.Add((x + 1, y));
                    if (y + 1 < grid[0].Length && grid[x][y + 1] == '1')
                        neighbors.Add((x, y + 1));
                    if (y - 1 >= 0 && grid[x][y - 1] == '1')
                        neighbors.Add((x, y - 1));

                    map[(x, y)] = neighbors;
                }
            }

            Dictionary<(int x, int y), bool> visited = new();
            var queue = new Queue<(int x, int y)>();

            var sum = 0;
            foreach (var keyValuePair in map)
            {
                if (visited.ContainsKey(keyValuePair.Key))
                    continue;

                var moves = keyValuePair.Value;
                foreach (var move in moves)
                    queue.Enqueue(move);

                while (queue.Count != 0)
                {
                    var move = queue.Dequeue();

                    if (!visited.TryAdd(move, true))
                        continue;

                    var nextMoves = map[move];
                    foreach (var nextMove in nextMoves)
                        queue.Enqueue(nextMove);
                }

                sum++;
            }

            return sum;
    }
}
