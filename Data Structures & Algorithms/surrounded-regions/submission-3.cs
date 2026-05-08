public class Solution {
    public void Solve(char[][] board) {
            var rows = board.Length;
            var cols = board[0].Length;
            var directions = new[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

            var queue = new Queue<(int x, int y)>();

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (i != 0 && i != rows - 1 && j != 0 && j != cols - 1)
                        continue;

                    if (board[i][j] != 'O')
                        continue;

                    queue.Enqueue((i, j));
                    board[i][j] = '#';
                }
            }

            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();

                foreach (var (dx, dy) in directions)
                {
                    var nx = x + dx;
                    var ny = y + dy;

                    if (nx < 0 || nx >= rows || ny < 0 || ny >= cols)
                        continue;

                    if (board[nx][ny] != 'O')
                        continue;

                    board[nx][ny] = '#';
                    queue.Enqueue((nx, ny));
                }                         
            }

            for (var i = 0; i < rows; i++)
                for (var j = 0; j < cols; j++)
                    board[i][j] = board[i][j] == '#' ? 'O' : 'X';
    }
}
