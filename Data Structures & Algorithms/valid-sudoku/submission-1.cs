public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        for (int r = 0; r < 9; r++)
        {
            var seen = new bool[10];
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                var i = board[r][c] - '0';
                if (seen[i]) return false;
                
                seen[i] = true;
            }
        }

        for (int c = 0; c < 9; c++)
        {
            var seen = new bool[10];
            for (int r = 0; r < 9; r++)
            {
                if (board[r][c] == '.') continue;

                var i = board[r][c] - '0';
                if (seen[i]) return false;
                
                seen[i] = true;
            }
        }

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                var seen = new bool[10];
                for (int row = r*3; row < r*3+3; row++)
                {
                    for (int col = c*3; col < c*3+3; col++)
                    {
                        if (board[row][col] == '.') continue;

                        var i = board[row][col] - '0';
                        if (seen[i]) return false;

                        seen[i] = true;
                    }
                }
            }
        }

        return true;
    }
}
