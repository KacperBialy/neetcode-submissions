public class Solution {
    public void Solve(char[][] board) {
            var rows = board.Length;
            var cols = board[0].Length;

            var directions = new[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
            var visited = new bool[rows, cols];
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'X' || visited[i, j])
                        continue;

                    var queue = new Queue<(int x, int y)>();
                    queue.Enqueue((i, j));
                    visited[i, j] = true;

                    var isSurrounded = true;
                    var pointsToChange = new List<(int x, int y)>()
                    {
                        (i, j)
                    };

                    while (queue.Count > 0)
                    {
                        var position = queue.Dequeue();

                        foreach (var (row, col) in directions)
                        {
                            var nextRow = position.x + row;
                            var nextCol = position.y + col;

                            if (nextRow < 0 || nextRow >= rows || nextCol < 0 || nextCol >= cols)
                            {
                                isSurrounded = false;
                                continue;
                            }

                            if (board[nextRow][nextCol] == 'X' || visited[nextRow, nextCol])
                                continue;

                            queue.Enqueue((nextRow, nextCol));
                            visited[nextRow, nextCol] = true;
                            pointsToChange.Add((nextRow, nextCol));
                        }
                    }

                    if (isSurrounded)
                    {
                        foreach (var (row, col) in pointsToChange)
                        {
                            board[row][col] = 'X';
                        }
                    }
                }
            }
    }
}
